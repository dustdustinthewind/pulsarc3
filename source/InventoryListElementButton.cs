// InventoryListElementButton
using AudioVisualizer;
using UnityEngine;

public class InventoryListElementButton : MonoBehaviour
{
	public SteamInventoryItem itemData;

	public GameObject infoCanvas;

	public GameObject selectedBadge;

	public bool isSelected;

	public void ACDBKEOINLH()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void GAIOOLFFAFI()
	{
		if (itemData.item.type == (InventoryItemType)5)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.JFGOMIIHHMK(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.MenuTheme)
		{
			isSelected = false;
			DKOMMIKCPKH();
			if (itemData.item.type == (InventoryItemType)7)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_Curve" + itemData.item.id + ".lastCheckpoint.perfectHits");
				GameObject.Find("_ExposureAdjustment").GetComponent<AudioSampler>().Init(oJCILKFONMH, 737f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LHIEKHPLMFI();
			}
		}
	}

	public void DBENNOKBPOJ()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void AIJGAJIOJDJ()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.MenuTheme)
		{
			isSelected = Singleton<ItemsHandler>.Instance.KOBNGLOLJHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void ONNJFFAFGGN()
	{
		if (itemData.item.type == (InventoryItemType)7)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.BGBONLPDHKH(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = false;
			EGDEEKCHHDB();
			if (itemData.item.type == (InventoryItemType)8)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("SUBMIT" + itemData.item.id + "CameraFilterPack/Antialiasing_FXAA");
				GameObject.Find("BlockSize").GetComponent<AudioSampler>().Init(oJCILKFONMH, 502f, false);
			}
			if (itemData.item.type == (InventoryItemType)8)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PIEPPKMBJHI();
			}
		}
	}

	public void MMECHKJKHIP()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void FHPNIFPJKCK()
	{
		if (itemData.item.type == (InventoryItemType)7)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.JIMODLHJFLN(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Player)
		{
			isSelected = false;
			DKOMMIKCPKH();
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("CameraFilterPack/TV_WideScreenVertical" + itemData.item.id + "_Value2");
				GameObject.Find("_ColorBuffer").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1134f);
			}
			if (itemData.item.type == InventoryItemType.Other)
			{
				Object.FindObjectOfType<ShaderItemHandler>().FEJAAGGMBOE();
			}
		}
	}

	public void Update()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void EAMCGODKIHI()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.JLEENFEIKHB(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void UpdateBadge()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void CMOBHGHIBKL()
	{
		if (itemData.item.type == InventoryItemType.Player)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = true;
			AGKAOPFPEOM();
			if (itemData.item.type == (InventoryItemType)8)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_FixDistance" + itemData.item.id + "#md5submitionfailed: ");
				GameObject.Find("LevelURLInputField").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1792f, false);
			}
			if (itemData.item.type == InventoryItemType.Player)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PFMJPIJONIP();
			}
		}
	}

	public void NALIFFCOCMN()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void DJAABMENCCB()
	{
		if (itemData.item.type == InventoryItemType.MenuTheme)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = true;
			DKOMMIKCPKH();
			if (itemData.item.type == InventoryItemType.Other)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_SSAO" + itemData.item.id + "ConnectToRegion: ");
				GameObject.Find("_ScreenResolution").GetComponent<AudioSampler>().Init(oJCILKFONMH, 614f);
			}
			if (itemData.item.type == (InventoryItemType)6)
			{
				Object.FindObjectOfType<ShaderItemHandler>().FEJAAGGMBOE();
			}
		}
	}

	public void JHPOIOELNCG()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != 0)
		{
			isSelected = Singleton<ItemsHandler>.Instance.ILHNOCIBMHK(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void KBOKCPHKCMI()
	{
		if (itemData.item.type == InventoryItemType.Other)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LCJIGDBJEBC(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)6)
		{
			isSelected = false;
			EGDEEKCHHDB();
			if (itemData.item.type == (InventoryItemType)7)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("Set crosshair emission (glow)" + itemData.item.id + "[PlayerBase] New highscore");
				GameObject.Find("_MainTex").GetComponent<AudioSampler>().Init(oJCILKFONMH, 279f);
			}
			if (itemData.item.type == (InventoryItemType)5)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LKEPIEEIMAE();
			}
		}
	}

	public void DKOMMIKCPKH()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void FABMDEHEDNO()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)6)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void ToggleInfo()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void FHGDNGBIFGF()
	{
		if (itemData.item.type == (InventoryItemType)5)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.BGBONLPDHKH(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != 0)
		{
			isSelected = false;
			DBENNOKBPOJ();
			if (itemData.item.type == InventoryItemType.Other)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("/" + itemData.item.id + "OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
				GameObject.Find("NewMapHandsCountSlider").GetComponent<AudioSampler>().Init(oJCILKFONMH, 252f, false);
			}
			if (itemData.item.type == (InventoryItemType)6)
			{
				Object.FindObjectOfType<ShaderItemHandler>().JHCJHPNAPDI();
			}
		}
	}

	public void HBNGFJBHLBE()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void AGKAOPFPEOM()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void FFBELAHLKDP()
	{
		if (itemData.item.type == InventoryItemType.Shader)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.JIMODLHJFLN(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)7)
		{
			isSelected = false;
			NBHKJJPLLHE();
			if (itemData.item.type == (InventoryItemType)5)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_PixelsPerMeterAtOneMeter" + itemData.item.id + "_Visualize");
				GameObject.Find("OxOD.lastPath").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1359f);
			}
			if (itemData.item.type == InventoryItemType.Shader)
			{
				Object.FindObjectOfType<ShaderItemHandler>().ALKBNPMCEOM();
			}
		}
	}

	public void EGDEEKCHHDB()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void OnClick()
	{
		if (itemData.item.type == InventoryItemType.Ticket)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = true;
			UpdateBadge();
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("Items/" + itemData.item.id + "/theme");
				GameObject.Find("AudioSampler").GetComponent<AudioSampler>().Init(oJCILKFONMH, 0f);
			}
			if (itemData.item.type == InventoryItemType.Shader)
			{
				Object.FindObjectOfType<ShaderItemHandler>().Init();
			}
		}
	}

	public void NHKMALPBBAP()
	{
		if (itemData.item.type == (InventoryItemType)8)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.JFGOMIIHHMK(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = false;
			DBENNOKBPOJ();
			if (itemData.item.type == (InventoryItemType)5)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_TexelOffsetScale" + itemData.item.id + "Joystick1Button4");
				GameObject.Find("new round").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1603f, false);
			}
			if (itemData.item.type == InventoryItemType.Other)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PMAGMPCMGPB();
			}
		}
	}

	public void FPEJJDJDHHD()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void JOLABCPNJGF()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void JAAJECBCCFM()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = Singleton<ItemsHandler>.Instance.KOBNGLOLJHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void PHLEPJNOBBN()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void DBDCIAIJOKG()
	{
		if (itemData.item.type == InventoryItemType.Player)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.BGBONLPDHKH(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.MenuTheme)
		{
			isSelected = true;
			NBHKJJPLLHE();
			if (itemData.item.type == (InventoryItemType)7)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("kick" + itemData.item.id + "/");
				GameObject.Find("Tab1Content").GetComponent<AudioSampler>().Init(oJCILKFONMH, 636f, false);
			}
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				Object.FindObjectOfType<ShaderItemHandler>().GCNKIJDNPMD();
			}
		}
	}

	public void NBHKJJPLLHE()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void IFCLGEEAHPG()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void KHLOKBDJLAO()
	{
		if (itemData.item.type == (InventoryItemType)8)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.JMFDJLNMBMO(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = true;
			UpdateBadge();
			if (itemData.item.type == InventoryItemType.Ticket)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_TimeX" + itemData.item.id + "_CenterX");
				GameObject.Find("id").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1889f);
			}
			if (itemData.item.type == (InventoryItemType)6)
			{
				Object.FindObjectOfType<ShaderItemHandler>().BKEFJPOHKDE();
			}
		}
	}

	public void LMJNNMHMFPL()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}
}
