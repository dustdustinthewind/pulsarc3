// InventoryListElementButton
using AudioVisualizer;
using UnityEngine;

public class InventoryListElementButton : MonoBehaviour
{
	public SteamInventoryItem itemData;

	public GameObject infoCanvas;

	public GameObject selectedBadge;

	public bool isSelected;

	public void LEAHIBJDMBI()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.MenuTheme)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void IKMELABKBHO()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void EOKMKOGGLPA()
	{
		if (itemData.item.type == InventoryItemType.Ticket)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.GOPHPPIEEPC(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = false;
			IEAHONJMIBF();
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_TimeX" + itemData.item.id + ". Client should be in a room. Current connectionStateDetailed: ");
				GameObject.Find("CameraFilterPack/Blend2Camera_BlueScreen").GetComponent<AudioSampler>().Init(oJCILKFONMH, 786f, false);
			}
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LLAHPNGMEOO();
			}
		}
	}

	public void LCJHDLKJEOM()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void PLBCPKCPMKA()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void BGFJOEPFOPM()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Player)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void FBABIGBHNJD()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void CBJHGLAOCCO()
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

	public void GMKOLBCOLMD()
	{
		if (itemData.item.type == (InventoryItemType)7)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LMGEELNOLJD(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)7)
		{
			isSelected = true;
			FBNBHBIJCCK();
			if (itemData.item.type == InventoryItemType.Other)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("blue" + itemData.item.id + ": ");
				GameObject.Find("CameraFilterPack/Pixelisation_Dot").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1290f, false);
			}
			if (itemData.item.type == (InventoryItemType)8)
			{
				Object.FindObjectOfType<ShaderItemHandler>().KOKDPAEJECC();
			}
		}
	}

	public void CMOBHGHIBKL()
	{
		if (itemData.item.type == InventoryItemType.Shader)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LMGEELNOLJD(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = false;
			IDKAHCHJGCH();
			if (itemData.item.type == InventoryItemType.Player)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_ScreenResolution" + itemData.item.id + "_ScreenResolution");
				GameObject.Find("_Color").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1387f, false);
			}
			if (itemData.item.type == InventoryItemType.Other)
			{
				Object.FindObjectOfType<ShaderItemHandler>().KJBJBNGJDAD();
			}
		}
	}

	public void HFJBIHGALEH()
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

	public void KDONBFDLAFC()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void HJNBGKOJPGE()
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

	public void DGCGGKMNPLD()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void GGCLKOJPPDD()
	{
		if (itemData.item.type == (InventoryItemType)7)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = true;
			NMFDDELOGNI();
			if (itemData.item.type == InventoryItemType.Ticket)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("CameraFilterPack/Drawing_NewCellShading" + itemData.item.id + "_TimeX");
				GameObject.Find(": ").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1587f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LLAHPNGMEOO();
			}
		}
	}

	public void HABHCAAKDPL()
	{
		if (itemData.item.type == InventoryItemType.Player)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = true;
			KDONBFDLAFC();
			if (itemData.item.type == InventoryItemType.Shader)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("nd" + itemData.item.id + "x");
				GameObject.Find("CameraFilterPack/Glasses_On").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1695f);
			}
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LBICLFNOLAK();
			}
		}
	}

	public void JCGMGLMADEN()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void LJPNDPHMCHG()
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

	public void JABGIOLEKPG()
	{
		if (itemData.item.type == (InventoryItemType)7)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.GOPHPPIEEPC(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = true;
			CBJHGLAOCCO();
			if (itemData.item.type == (InventoryItemType)8)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("CameraFilterPack/FX_superDot" + itemData.item.id + "Lag ");
				GameObject.Find("_SpotSize").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1267f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().ODFOEENHKCO();
			}
		}
	}

	public void HPNNCNNFMGK()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void OMILGANFFKP()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void GFOBBPMHKJF()
	{
		if (itemData.item.type == InventoryItemType.Ticket)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = true;
			HIPCPHBLGDF();
			if (itemData.item.type == InventoryItemType.Shader)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>(".lastCheckpoint.time" + itemData.item.id + " ");
				GameObject.Find("B:").GetComponent<AudioSampler>().Init(oJCILKFONMH, 668f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().OPKKBMCDOEM();
			}
		}
	}

	public void LAOCNFBGEDE()
	{
		if (itemData.item.type == InventoryItemType.Other)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.GOPHPPIEEPC(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)6)
		{
			isSelected = false;
			MFGDPAOLDAF();
			if (itemData.item.type == (InventoryItemType)5)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("CameraFilterPack/Film_Grain" + itemData.item.id + "[Right]");
				GameObject.Find("GridDataStoryboard").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1586f, false);
			}
			if (itemData.item.type == (InventoryItemType)5)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PMAGMPCMGPB();
			}
		}
	}

	public void ECPMLDBJIPH()
	{
		if (itemData.item.type == (InventoryItemType)5)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LMGEELNOLJD(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = true;
			AGKAOPFPEOM();
			if (itemData.item.type == InventoryItemType.Shader)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("/" + itemData.item.id + "1248864821");
				GameObject.Find("New SaveGame").GetComponent<AudioSampler>().Init(oJCILKFONMH, 872f, false);
			}
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PIEPPKMBJHI();
			}
		}
	}

	public void GDPKIPEBOBA()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void LINCNDBOKIC()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void IIPAHIBFIHH()
	{
		if (itemData.item.type == InventoryItemType.Other)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = true;
			CKMALGDGOIM();
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("CameraFilterPack/Atmosphere_Rain_Pro" + itemData.item.id + "_LutTex");
				GameObject.Find("Joystick1Button5").GetComponent<AudioSampler>().Init(oJCILKFONMH, 167f);
			}
			if (itemData.item.type == InventoryItemType.Other)
			{
				Object.FindObjectOfType<ShaderItemHandler>().ODFOEENHKCO();
			}
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

	public void ABNPOBCAKMH()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void PBEHPFKJOPC()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void LKNODALPANI()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void BLEKBEOFDPA()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void NCPAFCKGJEA()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void NLCODJFJOPI()
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

	public void JLPBFDFLBAF()
	{
		if (itemData.item.type == InventoryItemType.MenuTheme)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.GOPHPPIEEPC(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)6)
		{
			isSelected = false;
			IGDKFCNHNPJ();
			if (itemData.item.type == (InventoryItemType)5)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("#mapalreadyexistupdate" + itemData.item.id + "FToA");
				GameObject.Find("GenerationMenu").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1520f, false);
			}
			if (itemData.item.type == InventoryItemType.Shader)
			{
				Object.FindObjectOfType<ShaderItemHandler>().OPKKBMCDOEM();
			}
		}
	}

	public void MAABEAPENIB()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void HIJDKMKHNBB()
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

	public void IEAHONJMIBF()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void FOAPILFGDNI()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void IMAMKOPGADL()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void GCDLIKEDMCF()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Player)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void FHGDNGBIFGF()
	{
		if (itemData.item.type == (InventoryItemType)6)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = true;
			NLCODJFJOPI();
			if (itemData.item.type == (InventoryItemType)5)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_Bullet_11" + itemData.item.id + "ns");
				GameObject.Find(" not exist").GetComponent<AudioSampler>().Init(oJCILKFONMH, 327f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LMHFEBCKPDI();
			}
		}
	}

	public void FLNJCAHBDLL()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void PKHPNHBEKHA()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
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

	public void FCKDNGADGBH()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void ABFNJCEBIKA()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void IDKAHCHJGCH()
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

	public void MAJHNDJPAFM()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void BEELBPCCDIA()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void GLOPPPKPGBL()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void LHHFMKKKPDP()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void LPHKBPIIEMA()
	{
		if (itemData.item.type == InventoryItemType.Other)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.IBMAAHEAMDD(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != 0)
		{
			isSelected = true;
			FEMMOFHNGHJ();
			if (itemData.item.type == InventoryItemType.Player)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>(" " + itemData.item.id + "OK");
				GameObject.Find("shader.ghost").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1068f, false);
			}
			if (itemData.item.type == InventoryItemType.Ticket)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LCGMHCBNCDM();
			}
		}
	}

	public void MOGKDGPDPFL()
	{
		if (itemData.item.type == InventoryItemType.Shader)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.IBMAAHEAMDD(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = true;
			PEOCMBGNAJM();
			if (itemData.item.type == InventoryItemType.Other)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_DiffuseColor" + itemData.item.id + "VIGNETTE_BLUR");
				GameObject.Find("CameraFilterPack/3D_Myst").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1195f, false);
			}
			if (itemData.item.type == InventoryItemType.Other)
			{
				Object.FindObjectOfType<ShaderItemHandler>().KOKDPAEJECC();
			}
		}
	}

	public void PLBPKPAOFOK()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void NOADHINJGOD()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.OPADBCKHIFH(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void OBNBENFFJAC()
	{
		if (itemData.item.type == (InventoryItemType)6)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.IBMAAHEAMDD(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = true;
			LJPNDPHMCHG();
			if (itemData.item.type == (InventoryItemType)8)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("Map already submited. Update?" + itemData.item.id + "_Value");
				GameObject.Find("mapselector.filter.rateduponly").GetComponent<AudioSampler>().Init(oJCILKFONMH, 914f);
			}
			if (itemData.item.type == InventoryItemType.Player)
			{
				Object.FindObjectOfType<ShaderItemHandler>().EMOCEKPLGBK();
			}
		}
	}

	public void KCDBBPKIFNJ()
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

	public void EGLJKJOLPML()
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

	public void BNINBIKCCNG()
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

	public void FHPNIFPJKCK()
	{
		if (itemData.item.type == (InventoryItemType)8)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.GOPHPPIEEPC(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != 0)
		{
			isSelected = false;
			PEOCMBGNAJM();
			if (itemData.item.type == (InventoryItemType)6)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_TimeX" + itemData.item.id + "CameraFilterPack/FX_Spot");
				GameObject.Find("EventSystem").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1553f, false);
			}
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				Object.FindObjectOfType<ShaderItemHandler>().NOMLFPFGFBI();
			}
		}
	}

	public void MBPKLNFHAFH()
	{
		if (itemData.item.type == (InventoryItemType)6)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LMGEELNOLJD(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != 0)
		{
			isSelected = true;
			IEAHONJMIBF();
			if (itemData.item.type == (InventoryItemType)5)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_Value" + itemData.item.id + "SaveButton");
				GameObject.Find("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ").GetComponent<AudioSampler>().Init(oJCILKFONMH, 113f);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().KDJHONILJGK();
			}
		}
	}

	public void HIPCPHBLGDF()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.MJIPNOKOKCM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void HMNLHMLILKD()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void BHDPKGOKKPF()
	{
		if (itemData.item.type == InventoryItemType.MenuTheme)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != 0)
		{
			isSelected = false;
			LINCNDBOKIC();
			if (itemData.item.type == InventoryItemType.Player)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("JoinButton" + itemData.item.id + "GameMessagesDurationSlider");
				GameObject.Find("KickThePlayer").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1707f);
			}
			if (itemData.item.type == (InventoryItemType)6)
			{
				Object.FindObjectOfType<ShaderItemHandler>().OPKKBMCDOEM();
			}
		}
	}

	public void GHNIGKHJDFP()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void LMADKINICIN()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void NFEDLAOPHML()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void KHLOKBDJLAO()
	{
		if (itemData.item.type == (InventoryItemType)6)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LMGEELNOLJD(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = true;
			CBJHGLAOCCO();
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("[Up]" + itemData.item.id + "shader.frost");
				GameObject.Find("_NoiseTex").GetComponent<AudioSampler>().Init(oJCILKFONMH, 211f, false);
			}
			if (itemData.item.type == InventoryItemType.Other)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PIEPPKMBJHI();
			}
		}
	}

	public void BOJGEBBIFAP()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void KBOKCPHKCMI()
	{
		if (itemData.item.type == InventoryItemType.MenuTheme)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.MenuTheme)
		{
			isSelected = true;
			FBNBHBIJCCK();
			if (itemData.item.type == InventoryItemType.Ticket)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("deleteall" + itemData.item.id + "misses");
				GameObject.Find("ok").GetComponent<AudioSampler>().Init(oJCILKFONMH, 938f);
			}
			if (itemData.item.type == InventoryItemType.Shader)
			{
				Object.FindObjectOfType<ShaderItemHandler>().KOKDPAEJECC();
			}
		}
	}

	public void NKLIHNJCHOG()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void PHJJHFBLICM()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void HCIPECAOGIA()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void BGDONBMDPGM()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.MenuTheme)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void CKMALGDGOIM()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.OPADBCKHIFH(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void GLMCDMOHOKD()
	{
		if (itemData.item.type == InventoryItemType.MenuTheme)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.GOPHPPIEEPC(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)7)
		{
			isSelected = true;
			CKMALGDGOIM();
			if (itemData.item.type == (InventoryItemType)6)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("player.goldarc" + itemData.item.id + "[Up]");
				GameObject.Find("Overlay").GetComponent<AudioSampler>().Init(oJCILKFONMH, 148f, false);
			}
			if (itemData.item.type == InventoryItemType.Player)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PJILLPKFCPO();
			}
		}
	}

	public void NONKILKPPDO()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void COGBDFKOHKK()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void ANKPKJEICCM()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void AEHHOCFIHIN()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void KCEIKPLPJMK()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void PEOCMBGNAJM()
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

	public void KMEPPEEEGGP()
	{
		if (itemData.item.type == (InventoryItemType)6)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.IAEADNIKOEO(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = false;
			OEKOOPIOEPF();
			if (itemData.item.type == InventoryItemType.Player)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("CameraFilterPack/TV_WideScreenHV" + itemData.item.id + "_Value2");
				GameObject.Find("challenges.").GetComponent<AudioSampler>().Init(oJCILKFONMH, 479f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PAFMNAIDAFH();
			}
		}
	}

	public void EKEIDLFNHJF()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.MJIPNOKOKCM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void BMJKOOJLLBO()
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

	public void OFHICEMAIOL()
	{
		if (itemData.item.type == InventoryItemType.Player)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LMGEELNOLJD(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = true;
			BMJKOOJLLBO();
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("Error: you cannot read this stream that you are writing!" + itemData.item.id + "Set particles gravity");
				GameObject.Find("#ok").GetComponent<AudioSampler>().Init(oJCILKFONMH, 846f);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LLAHPNGMEOO();
			}
		}
	}

	public void DKOMMIKCPKH()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void MAMLCENOEMD()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void FBNBHBIJCCK()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.MJIPNOKOKCM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void GBIPPMKDALF()
	{
		if (itemData.item.type == InventoryItemType.Other)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.IAEADNIKOEO(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = true;
			HIPCPHBLGDF();
			if (itemData.item.type == InventoryItemType.Player)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}" + itemData.item.id + "Fade");
				GameObject.Find("MenuPlayButton").GetComponent<AudioSampler>().Init(oJCILKFONMH, 1506f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().LCGMHCBNCDM();
			}
		}
	}

	public void NMFDDELOGNI()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void FEMMOFHNGHJ()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.OPADBCKHIFH(itemData.item.type, itemData.steamid);
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
			Singleton<ItemsHandler>.Instance.POFFJLELKBM(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void HIFLPHLGLFG()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)5)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void AGBKMHIENCF()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void ILKIENOLFCK()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
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

	public void OCANGILMJMP()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void FBIHDEJMLBD()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void BCFJHBFKKHH()
	{
		if (itemData.item.type == InventoryItemType.Player)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Player)
		{
			isSelected = false;
			HJNBGKOJPGE();
			if (itemData.item.type == (InventoryItemType)5)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("LoadMapCanvas" + itemData.item.id + "CameraFilterPack/Drawing_Manga_Flash");
				GameObject.Find("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ").GetComponent<AudioSampler>().Init(oJCILKFONMH, 529f);
			}
			if (itemData.item.type == InventoryItemType.Other)
			{
				Object.FindObjectOfType<ShaderItemHandler>().FECMEIJGLJI();
			}
		}
	}

	public void NNPGOODLNEO()
	{
		if (itemData.item.type == InventoryItemType.Ticket)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.GOPHPPIEEPC(0, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)7)
		{
			isSelected = true;
			FCKDNGADGBH();
			if (itemData.item.type == (InventoryItemType)7)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("_Wavy" + itemData.item.id + "Source directory does not exist or could not be found: ");
				GameObject.Find("InfoCanvas").GetComponent<AudioSampler>().Init(oJCILKFONMH, 459f, false);
			}
			if (itemData.item.type == (InventoryItemType)6)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PAFMNAIDAFH();
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

	public void FABMDEHEDNO()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != 0)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void LLDHEJIEDHO()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)8)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void OEKOOPIOEPF()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.OPADBCKHIFH(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void IGDKFCNHNPJ()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.OPADBCKHIFH(itemData.item.type, itemData.steamid);
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void OEENOOGEEHD()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void OBAEDJJDCPN()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Player)
		{
			isSelected = Singleton<ItemsHandler>.Instance.CDPJMGIHHHF(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}

	public void EHBMHKDHAEG()
	{
		if (itemData.item.type == (InventoryItemType)8)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.LMGEELNOLJD(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != (InventoryItemType)6)
		{
			isSelected = false;
			PLBCPKCPMKA();
			if (itemData.item.type == InventoryItemType.Other)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("/icon" + itemData.item.id + "InventoryButton");
				GameObject.Find("LastHighScoreText").GetComponent<AudioSampler>().Init(oJCILKFONMH, 720f);
			}
			if (itemData.item.type == InventoryItemType.Ticket)
			{
				Object.FindObjectOfType<ShaderItemHandler>().CDDHLFNJOGC();
			}
		}
	}

	public void JFPABIAFFGM()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(infoCanvas.activeSelf);
		}
	}

	public void AKEIPNLIHNL()
	{
		if (itemData.item.type == (InventoryItemType)5)
		{
			StartCoroutine(Singleton<ContributorSystem>.Instance.IBMAAHEAMDD(1, null, string.Empty + itemData.steamid));
		}
		if (!isSelected && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Ticket)
		{
			isSelected = false;
			FOAPILFGDNI();
			if (itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip oJCILKFONMH = Resources.Load<AudioClip>("VHS2" + itemData.item.id + "(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])");
				GameObject.Find("_Radius").GetComponent<AudioSampler>().Init(oJCILKFONMH, 816f, false);
			}
			if (itemData.item.type == (InventoryItemType)7)
			{
				Object.FindObjectOfType<ShaderItemHandler>().PAFMNAIDAFH();
			}
		}
	}

	public void MFGDPAOLDAF()
	{
		if (isSelected)
		{
			Singleton<ItemsHandler>.Instance.DFNHLHFLCJD(itemData.item.type, itemData.steamid);
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

	public void LPPNCDOPDFE()
	{
		if ((bool)infoCanvas)
		{
			infoCanvas.SetActive(!infoCanvas.activeSelf);
		}
	}

	public void EHCGBJDFMHG()
	{
		if (itemData != null && itemData.item.type != 0 && itemData.item.type != InventoryItemType.Shader)
		{
			isSelected = Singleton<ItemsHandler>.Instance.EnquippedItem(itemData.item.type) == itemData.steamid;
		}
		if ((bool)selectedBadge)
		{
			selectedBadge.SetActive(isSelected);
		}
	}
}
