using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Security;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class InAppPurchase : MonoBehaviour, IStoreListener
{
	static IStoreController storeController = null;
	static string[] sProductIds;

	[SerializeField] string txtLog;

	void Awake()
	{
		if (storeController == null)
		{
			sProductIds = new string[] { "ad_skip", "auto_click", "double_boost", "decuple_boost", "donation" };
			InitStore();
		}
	}

	void InitStore()
	{
		ConfigurationBuilder builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
		builder.AddProduct(sProductIds[0], ProductType.NonConsumable, new IDs { { sProductIds[0], GooglePlay.Name } });
		builder.AddProduct(sProductIds[1], ProductType.NonConsumable, new IDs { { sProductIds[1], GooglePlay.Name } });
		builder.AddProduct(sProductIds[2], ProductType.NonConsumable, new IDs { { sProductIds[2], GooglePlay.Name } });
		builder.AddProduct(sProductIds[3], ProductType.NonConsumable, new IDs { { sProductIds[3], GooglePlay.Name } });
		builder.AddProduct(sProductIds[4], ProductType.Consumable, new IDs { { sProductIds[4], GooglePlay.Name } });

		UnityPurchasing.Initialize(this, builder);
	}

	void IStoreListener.OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
		storeController = controller;
		txtLog = "결제 기능 초기화 완료";
		Debug.Log(txtLog);
	}

	void IStoreListener.OnInitializeFailed(InitializationFailureReason error)
	{
		txtLog = "OnInitializeFailed" + error;
		Debug.Log(txtLog);
	}

	public void OnBtnPurchaseClicked(int index)
	{
		if (storeController == null)
		{
			txtLog = "구매 실패 : 결제 기능 초기화 실패";
			Debug.Log(txtLog);
		}
		else
			storeController.InitiatePurchase(sProductIds[index]);
	}

	PurchaseProcessingResult IStoreListener.ProcessPurchase(PurchaseEventArgs e)
	{
		bool isSuccess = true;
#if UNITY_ANDROID && !UNITY_EDITOR
		CrossPlatformValidator validator = new CrossPlatformValidator(GooglePlayTangle.Data(), AppleTangle.Data(), Application.identifier);
		try
		{
			IPurchaseReceipt[] result = validator.Validate(e.purchasedProduct.receipt);
			for(int i = 0; i < result.Length; i++)
				Analytics.Transaction(result[i].productID, e.purchasedProduct.metadata.localizedPrice, e.purchasedProduct.metadata.isoCurrencyCode, result[i].transactionID, null);
		}
		catch (IAPSecurityException)
		{
			isSuccess = false;
		}
#endif
		if (isSuccess)
		{
			Debug.Log("구매 완료");
			if (e.purchasedProduct.definition.id.Equals(sProductIds[0]))
				AdRemove();
			else if (e.purchasedProduct.definition.id.Equals(sProductIds[1]))
				AutoClick();
			else if (e.purchasedProduct.definition.id.Equals(sProductIds[2]))
				DoubleBoost();
			else if (e.purchasedProduct.definition.id.Equals(sProductIds[3]))
				DecupleBoost();
			else if (e.purchasedProduct.definition.id.Equals(sProductIds[4]))
				Donate();
		}
		else
		{
			txtLog = "구매 실패 : 비정상 결제";
			Debug.Log(txtLog);
		}

		return PurchaseProcessingResult.Complete;
	}

	void IStoreListener.OnPurchaseFailed(Product i, PurchaseFailureReason error)
	{
		if (!error.Equals(PurchaseFailureReason.UserCancelled))
		{
			txtLog = "구매 실패 : " + error;
			Debug.Log(txtLog);
		}
	}

	void AdRemove()
	{
		GameManager.InAppPur_AdSkip = true;
	}

	void AutoClick()
	{
		GameManager.InAppPur_AutoClick = true;

		StartCoroutine(GameManager.AutoClcik());
	}

	void DoubleBoost()
	{
		GameManager.InAppPur_DoubleBoost = true;

		if(GameManager.InAppPur_DecupleBoost == true)
		{
			GameManager.CashBonus = 20;
		}
		else
		{
			GameManager.CashBonus = 2;
		}
	}

	void DecupleBoost()
	{
		GameManager.InAppPur_DecupleBoost = true;

		if(GameManager.InAppPur_DoubleBoost == true)
		{
			GameManager.CashBonus = 20;
		}
		else
		{
			GameManager.CashBonus = 10;
		}
	}

	void Donate()
	{

	}
}