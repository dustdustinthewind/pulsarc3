// ShaderItemHandler
using Assets.Pixelation.Scripts;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CinematicEffects;
using UnityStandardAssets.ImageEffects;

public class ShaderItemHandler : MonoBehaviour
{
	public AnimationCurve up;

	public AnimationCurve down;

	private bool KCFOBKNIELP;

	private void KFACDBHDAOD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CGJOIHHJLEL();
		}
	}

	private void LBPCODPOJAH()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DABDHKLHECK();
		}
	}

	private void GDJNNMGCGGK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_ChannelMixerGreen" + InventoryItemType.Ticket.ToString().ToLower(), "Failed to Destroy objects of playerId: ");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "title";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Tab1Content";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use") && id == "_ScreenResolution";
			if (id == "settings.gamemessagesduration")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1854f;
			}
			else if (id == "x")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 252f;
			}
			GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "3;4;9;10;21x6";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "mapselector.orderby";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == " x ";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "[PlayerController] ";
		}
		if ((bool)GameObject.Find("_Value") && (bool)GameObject.Find("_Blend").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value").GetComponentInChildren<Image>().enabled = id == "_TimeX";
		}
		KCFOBKNIELP = false;
	}

	private void DNENFLNCIJP()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LJLKKJEFFLK();
		}
	}

	private void DDBOODLPCAM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DLIGNKPKAOP();
		}
	}

	public void HINJNBJFGHD()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GCNNKEMKPGM();
		}
	}

	public void PHIBAJAFNEO()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LJLKKJEFFLK();
		}
	}

	private void KBLLBKNNBGO()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("_MaxRadiusOrKInPaper" + InventoryItemType.Shader.ToString().ToLower(), "Joystick1Button6");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "GlassAberration";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "CameraFilterPack/Drawing_Manga_Flash_Color";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "CameraFilterPack_Paper1") && id == "Could not execute RPC ";
			if (id == "accuracy")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1856f;
			}
			else if (id == "CameraFilterPack/Blend2Camera_Luminosity")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 242f;
			}
			GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "#ok";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "menu.selectedplaymode";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_TimeX";
		}
		if ((bool)GameObject.Find(" canvas not found") && (bool)GameObject.Find("/").GetComponentInChildren<Image>())
		{
			GameObject.Find("[").GetComponentInChildren<Image>().enabled = id == "{}";
		}
		KCFOBKNIELP = true;
	}

	private void AAPKBNDHBLI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			AGMEELGLEEE();
		}
	}

	public void CKJCPBPMBFF()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			OOHLEMKHNKJ();
		}
	}

	private void CGBHOELMAOC()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LKBBGBBEJKP();
		}
	}

	private void DLIGNKPKAOP()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_ScreenResolution" + ((InventoryItemType)8).ToString().ToLower(), "_FresnelFade");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "inventory.itemscash";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "LoadMapCanvas";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "EventSystem" || id == "JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
			if (id == "Save the map before exiting?")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1966f;
			}
			else if (id == "Out {0,4} | In {1,4} | Sum {2,4}")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1087f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "UnityEngine.MonoBehaviour";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "Can't set visible when not in that room.";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "ticket";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "ticket";
		}
		if ((bool)GameObject.Find("Protocol switch from: ") && (bool)GameObject.Find("B").GetComponentInChildren<Image>())
		{
			GameObject.Find("Hidden/Subpixel Morphological Anti-aliasing").GetComponentInChildren<Image>().enabled = id == "{0}{1}{2}";
		}
		KCFOBKNIELP = true;
	}

	public void LLAHPNGMEOO()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CGJOIHHJLEL();
		}
	}

	private void MDCFIHDPLIG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			FHADLGLMIBG();
		}
	}

	public void JEFKEOFNKIM()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DBONMCBDEPG();
		}
	}

	private void DABDHKLHECK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("?page=addtip" + ((InventoryItemType)6).ToString().ToLower(), "_Near");
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "[Right-Left]";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Maps Editor v.";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "-showlogs") && id == "_Value2";
			if (id == "mapselector.tags.")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 688f;
			}
			else if (id == " Server: ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 334f;
			}
			GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "MenuScene";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == " item(s) in inventory";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Value2";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "settings.disablestoryboard";
		}
		if ((bool)GameObject.Find("OK") && (bool)GameObject.Find("inventory.itemscash").GetComponentInChildren<Image>())
		{
			GameObject.Find("Tab2Content").GetComponentInChildren<Image>().enabled = id == "[LevelEditorScene] Error: You're not logged into Steam!";
		}
		KCFOBKNIELP = true;
	}

	private void PLKGKBPAIOP()
	{
		string s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("{0}{1}:{2}" + InventoryItemType.Player.ToString().ToLower(), " from: ");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "Skipping region because it's not in PhotonServerSettings.EnabledRegions: ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "maps.";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "RestartButton") && id == "_Value4";
			if (id == "https://bugs.khb-soft.ru/set_project.php?project_id=1")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 993f;
			}
			else if (id == " does not exist!")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 858f;
			}
			GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "R:";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "Can't set Room.MaxPlayers to: ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Default UI Material";
		}
		if ((bool)GameObject.Find("The shader ") && (bool)GameObject.Find("_TimeX").GetComponentInChildren<Image>())
		{
			GameObject.Find("wss://").GetComponentInChildren<Image>().enabled = id == "_BlurVector";
		}
		KCFOBKNIELP = true;
	}

	public void HBKEHHCMMBN()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			MOABIEIPGHN();
		}
	}

	private void IDIIELPAMCJ()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			KIBEDOCDGCG();
		}
	}

	private void FHADLGLMIBG()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), "shader.none");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(@string)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "shader.invert";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "shader.pixel";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "shader.future" || id == "shader.frost";
			if (id == "shader.future")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1f;
			}
			else if (id == "shader.frost")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1f;
			}
			GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "shader.ghost";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "shader.sunny";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "shader.crispwinter";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "shader.sunny";
		}
		if ((bool)GameObject.Find("FrostCanvas") && (bool)GameObject.Find("FrostCanvas").GetComponentInChildren<Image>())
		{
			GameObject.Find("FrostCanvas").GetComponentInChildren<Image>().enabled = id == "shader.frost";
		}
		KCFOBKNIELP = true;
	}

	public void GAJEPOEIOPP()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKOINEADGNA();
		}
	}

	public void EFEONCCCKNP()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKOINEADGNA();
		}
	}

	public void EHGHEEJNPIN()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			BEPABLJNPOE();
		}
	}

	private void BEPABLJNPOE()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("CameraFilterPack/Atmosphere_Rain_Pro" + InventoryItemType.Other.ToString().ToLower(), "shader.frost");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(@string)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == ".";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == ". Verify the Prefab is in a Resources folder (and not in a subfolder)";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Value2" || id == "/";
			if (id == ": ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 762f;
			}
			else if (id == "(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 15f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "{0}";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "finished";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_TimeX";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "CameraFilterPack_Broken_Screen1";
		}
		if ((bool)GameObject.Find("Middle Click") && (bool)GameObject.Find("BadgeText").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Amount").GetComponentInChildren<Image>().enabled = id == "id";
		}
		KCFOBKNIELP = false;
	}

	public void JJFLHFCBENC()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			BEPABLJNPOE();
		}
	}

	public void CPJHNDOBFOD()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LKBBGBBEJKP();
		}
	}

	private void NCPAFCKGJEA()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GCNNKEMKPGM();
		}
	}

	private void MDACKFPPNAE()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("Texture2" + InventoryItemType.Other.ToString().ToLower(), "settings.volume.sfx");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "/icon";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_Vibrance";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Please specify either t or f.") && id == "Set Particle Size";
			if (id == "Item created: Id: ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1540f;
			}
			else if (id == "_TimeX")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 91f;
			}
			GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "value";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "inventory.selected.";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "BloomShaderValueSlider";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "/config";
		}
		if ((bool)GameObject.Find("_Value5") && (bool)GameObject.Find("Instantiating: ").GetComponentInChildren<Image>())
		{
			GameObject.Find("[PlayerBase] New highscore").GetComponentInChildren<Image>().enabled = id == "Fade";
		}
		KCFOBKNIELP = false;
	}

	private void Update()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			FHADLGLMIBG();
		}
	}

	public void LHIEKHPLMFI()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PNLBMKHFPEA();
		}
	}

	private void OOHLEMKHNKJ()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("[Left]" + InventoryItemType.MenuTheme.ToString().ToLower(), "Set satellite MinVertexDistance - how much distance should be between to points of the trail line");
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(@string)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "steamid";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Scrollbar";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "_TimeX") && id == "https://store.steampowered.com/recommended/recommendgame/";
			if (id == "YES")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1650f;
			}
			else if (id == "_ScreenResolution")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 11f;
			}
			GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "Tab2Content";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "The given 2D texture ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Bloom2";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ";
		}
		if ((bool)GameObject.Find("No Camera attached!") && (bool)GameObject.Find("FileMenu").GetComponentInChildren<Image>())
		{
			GameObject.Find("BitsData").GetComponentInChildren<Image>().enabled = id == "#score";
		}
		KCFOBKNIELP = true;
	}

	public void JHCJHPNAPDI()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CGJOIHHJLEL();
		}
	}

	private void DEBPOMCFBJO()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("Waiting to start" + ((InventoryItemType)7).ToString().ToLower(), "value");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "bloomintencity:";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Start Color's hex value #RRGGBBAA";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Value" || id == "_Green_B";
			if (id == "RequestForPickupItems")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 780f;
			}
			else if (id == "health")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1218f;
			}
			GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "z";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_BlurCoe";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Items/";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_MainTex2";
		}
		if ((bool)GameObject.Find("Jump") && (bool)GameObject.Find("Joystick1Button2").GetComponentInChildren<Image>())
		{
			GameObject.Find("_MainTex2").GetComponentInChildren<Image>().enabled = id == "_ScreenResolution";
		}
		KCFOBKNIELP = true;
	}

	public void IFGOHEOEGKH()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GDJNNMGCGGK();
		}
	}

	private void KIBEDOCDGCG()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("X" + InventoryItemType.Other.ToString().ToLower(), "(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "OnDeserialize";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Change Note:") && id == "{0}sec average:";
			if (id == ") error: ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 837f;
			}
			else if (id == "_Amount")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 350f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == " Message: ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_Value";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "RecieveChatActionMessage";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_Offset";
		}
		if ((bool)GameObject.Find("Mouse") && (bool)GameObject.Find("settings_bindings_sec_").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value2").GetComponentInChildren<Image>().enabled = id == "Bad parameters for init! Use \"init\" or \"init <savename>\"";
		}
		KCFOBKNIELP = true;
	}

	public void CDDHLFNJOGC()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DEPPOJEPCJC();
		}
	}

	public void PFMJPIJONIP()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			FHCANIGKFLD();
		}
	}

	public void Init()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			FHADLGLMIBG();
		}
	}

	private void GCNNKEMKPGM()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("SpawnObj" + InventoryItemType.Player.ToString().ToLower(), "CameraFilterPack/Color_BrightContrastSaturation");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "CameraFilterPack/Blur_Blurry";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == " or player:";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "ItemNameText" || id == "_ScreenResolution";
			if (id == "_ColorRGB")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 551f;
			}
			else if (id == "_FixDistance")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1813f;
			}
			GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_MainTex2";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "NEW";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_ProjInfo";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Result for ";
		}
		if ((bool)GameObject.Find("Editor/") && (bool)GameObject.Find(".lastCheckpoint.bgcolor").GetComponentInChildren<Image>())
		{
			GameObject.Find("Ownership mode == fixed. Ignoring request.").GetComponentInChildren<Image>().enabled = id == "#forever";
		}
		KCFOBKNIELP = true;
	}

	private void KDJEJBBDILE()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DBONMCBDEPG();
		}
	}

	private void COGBDFKOHKK()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NDACFLFLANE();
		}
	}

	private void DKLJCAINIDG()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA(".icon" + ((InventoryItemType)8).ToString().ToLower(), "mapid");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "...";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "[MapsData] User's maps was loaded";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Parent object ID. Case-Sensitive") && id == "Most likely the game became empty during the switch to GameServer.";
			if (id == "_BlurVector")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 119f;
			}
			else if (id == "Texture2")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 935f;
			}
			GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "\t";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Value4";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "settings.volume.menu";
		}
		if ((bool)GameObject.Find("_DistortionWave") && (bool)GameObject.Find("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data").GetComponentInChildren<Image>())
		{
			GameObject.Find("shader.future").GetComponentInChildren<Image>().enabled = id == "Sep";
		}
		KCFOBKNIELP = false;
	}

	private void ONJOOAAILAJ()
	{
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("warning: Audio Source: " + ((InventoryItemType)7).ToString().ToLower(), "CameraFilterPack/Vision_AuraDistortion");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "float,10";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_DistortionSize";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Joystick1Button2") && id == "Set sun min/max size";
			if (id == "_Visualize")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1623f;
			}
			else if (id == "true")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 288f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "z";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "Outgoing: \n";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "blue";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "#done";
		}
		if ((bool)GameObject.Find("UseFinalGlassColor") && (bool)GameObject.Find("<b>#").GetComponentInChildren<Image>())
		{
			GameObject.Find("skins").GetComponentInChildren<Image>().enabled = id == "false";
		}
		KCFOBKNIELP = false;
	}

	private void OCMKCBBCEFG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ABBNNMHMLOI();
		}
	}

	private void JOMJICOMCEK()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_ScreenResolution" + ((InventoryItemType)7).ToString().ToLower(), "<b>");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_Value4";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_Value3";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "float,0") && id == "_TimeX";
			if (id == "_Distortion")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1235f;
			}
			else if (id == "_Threshhold")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 401f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "SpawnObj";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "RT";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Fade";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "action";
		}
		if ((bool)GameObject.Find("_ScreenResolution") && (bool)GameObject.Find("Gameplay/sprite").GetComponentInChildren<Image>())
		{
			GameObject.Find("_ForegroundBlurExtrude").GetComponentInChildren<Image>().enabled = id == " ";
		}
		KCFOBKNIELP = true;
	}

	private void ANKIJGCGCBF()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DBONMCBDEPG();
		}
	}

	private void FJHFOBHJEHL()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LAGGOOCMLBJ();
		}
	}

	private void OPCLBGHAPMG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JOMJICOMCEK();
		}
	}

	private void FHCANIGKFLD()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("[PlayerController] " + InventoryItemType.MenuTheme.ToString().ToLower(), "id");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "CameraFilterPack/Blend2Camera_BlueScreen";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "RestartButton";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Wavy" || id == "EventMenu";
			if (id == "_ScreenResolution")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1633f;
			}
			else if (id == "Case-Sensitive")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1914f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "CameraFilterPack/Blur_Steam";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "setint";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Most likely the game became empty during the switch to GameServer.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GameObject.Find("Set Sun MinSize") && (bool)GameObject.Find("SpeedSlider").GetComponentInChildren<Image>())
		{
			GameObject.Find("player.goldlollipop").GetComponentInChildren<Image>().enabled = id == "request";
		}
		KCFOBKNIELP = true;
	}

	private void JMFMKCDKGHK()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("_Blue_G" + ((InventoryItemType)6).ToString().ToLower(), "ShineEffect");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "Protocol switch from: ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == ".completedMaps";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "_Value5") && id == "/icon";
			if (id == "_Value2")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 975f;
			}
			else if (id == "Ignored PU RPC, cause item is inactive. ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1668f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "ShadersToggle";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "LevelConfigButton";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == ".highscore";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_Brightness";
		}
		if ((bool)GameObject.Find("_Value") && (bool)GameObject.Find("CameraFilterPack/Blur_Steam").GetComponentInChildren<Image>())
		{
			GameObject.Find("workshop.").GetComponentInChildren<Image>().enabled = id == "shader.future";
		}
		KCFOBKNIELP = true;
	}

	private void GLLNAELOMBK()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_Value3" + InventoryItemType.MenuTheme.ToString().ToLower(), "<b>#");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "settings.shaders.bloomintencity";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_MaxRadiusOrKInPaper";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == " ") && id == "Lag ";
			if (id == "_CenterX")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1013f;
			}
			else if (id == "UpperMid")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1392f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "Editor/";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "#tryagain";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Turn";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "#{0:00} '{1}'{2} {3}";
		}
		if ((bool)GameObject.Find("[PlayerController] ") && (bool)GameObject.Find("_TexelOffsetScale").GetComponentInChildren<Image>())
		{
			GameObject.Find("CameraFilterPack/Blend2Camera_Overlay").GetComponentInChildren<Image>().enabled = id == "seconds";
		}
		KCFOBKNIELP = false;
	}

	public void MIAIEKCLEAO()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DLIGNKPKAOP();
		}
	}

	private void OBAEDJJDCPN()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LAGGOOCMLBJ();
		}
	}

	private void KCDBBPKIFNJ()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			FHCANIGKFLD();
		}
	}

	private void IKIDIJLIGOH()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CGJOIHHJLEL();
		}
	}

	private void KMEONPMCNJG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			MDACKFPPNAE();
		}
	}

	private void LLDHEJIEDHO()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			AGMEELGLEEE();
		}
	}

	public void LKEPIEEIMAE()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			MDACKFPPNAE();
		}
	}

	public void GINPIKEJGJD()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ONJOOAAILAJ();
		}
	}

	private void NDACFLFLANE()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("mapselector.tags." + InventoryItemType.Shader.ToString().ToLower(), ":");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == ".status";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_Size";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_ScreenResolution" || id == "Creating awesome map";
			if (id == "BitsData")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 20f;
			}
			else if (id == "[NetworkManager] Found ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1006f;
			}
			GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[MapsStats] Map ID: ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_Level";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Working commands:\nreset <challengeid>\nresetall";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "https://steamcommunity.com/sharedfiles/filedetails/?id=";
		}
		if ((bool)GameObject.Find("player.licenceaccepted") && (bool)GameObject.Find("\\\\").GetComponentInChildren<Image>())
		{
			GameObject.Find("GlassAberration").GetComponentInChildren<Image>().enabled = id == "CameraFilterPack_VHS2";
		}
		KCFOBKNIELP = false;
	}

	private void LKBBGBBEJKP()
	{
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("Result for " + InventoryItemType.Shader.ToString().ToLower(), "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "PunSupportLogger";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "RecieveChatMessage";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Source: ") && id == "SetRotation";
			if (id == "/files/editor_manual.pdf")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 372f;
			}
			else if (id == "/")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1654f;
			}
			GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[Up]";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "#finished";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "TwoHands";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "#ok";
		}
		if ((bool)GameObject.Find("cameramovements:") && (bool)GameObject.Find("_Value2").GetComponentInChildren<Image>())
		{
			GameObject.Find("icon").GetComponentInChildren<Image>().enabled = id == "GlassAberration";
		}
		KCFOBKNIELP = true;
	}

	private void CGJOIHHJLEL()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO(".a" + ((InventoryItemType)7).ToString().ToLower(), "_Glitch");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "menutheme.summerbreeze";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_TimeX";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "_TimeX") && id == "[LevelEditorScene] Error: Timeout :S";
			if (id == "_Distortion")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1576f;
			}
			else if (id == "default")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 917f;
			}
			GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_FinalReflectionTexture";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "[PlayerBase] Unknown event: ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "player.dragon";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "false";
		}
		if ((bool)GameObject.Find("_Near") && (bool)GameObject.Find("#scoresubmitionfailed: ").GetComponentInChildren<Image>())
		{
			GameObject.Find("maps.").GetComponentInChildren<Image>().enabled = id == "shader.future";
		}
		KCFOBKNIELP = true;
	}

	private void PKOINEADGNA()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_DistCenterScale" + InventoryItemType.MenuTheme.ToString().ToLower(), "_Value7");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "menu.playedpage";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "SetRotation";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "\nCreated by Oxy949" || id == "_VignettingColor";
			if (id == "settings_bindings_")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 976f;
			}
			else if (id == "BitsData")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 131f;
			}
			GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_Amount";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "[LobbyPlayerElement] Created lpe for ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "pointBuffer";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_Value6";
		}
		if ((bool)GameObject.Find("_MainTex2") && (bool)GameObject.Find("Editor").GetComponentInChildren<Image>())
		{
			GameObject.Find("_FixDistance").GetComponentInChildren<Image>().enabled = id == "IntraSig";
		}
		KCFOBKNIELP = false;
	}

	private void JMCFOJNCCLJ()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("GameScene" + ((InventoryItemType)8).ToString().ToLower(), "_XCrop");
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(@string)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "<b>#";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "player.ice";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "ShadersToggle") && id == "CameraFilterPack/Drawing_Manga5";
			if (id == " TimeOfRespawn: ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 660f;
			}
			else if (id == "CameraFilterPack/TV_LED")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 701f;
			}
			GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "EnableRankingToggle";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "ScrollPanel";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_CenterY";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "#tryagain";
		}
		if ((bool)GameObject.Find("_TimeX") && (bool)GameObject.Find("_MainTex").GetComponentInChildren<Image>())
		{
			GameObject.Find("x").GetComponentInChildren<Image>().enabled = id == "_SizeX";
		}
		KCFOBKNIELP = false;
	}

	private void PNLBMKHFPEA()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("yyyy-MM-dd HH:mm:ss" + InventoryItemType.Other.ToString().ToLower(), "There is already a virtual axis named ");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "Source directory does not exist or could not be found: ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "PenaltyScoreText";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "[PlayerController] ") && id == "LoadMapCanvas";
			if (id == "LB")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 571f;
			}
			else if (id == ".a")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1482f;
			}
			GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "CameraFilterPack/3D_Distortion";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "EventSystem";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == ".lastCheckpoint.incorrectScore";
		}
		if ((bool)GameObject.Find("_TimeX") && (bool)GameObject.Find("88f00bdf0ad61b16b803971ebe071962").GetComponentInChildren<Image>())
		{
			GameObject.Find("BitsData").GetComponentInChildren<Image>().enabled = id == "Unknown player asked for PickupItems";
		}
		KCFOBKNIELP = true;
	}

	public void CPFOEFKOJGA()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DABDHKLHECK();
		}
	}

	private void LAGGOOCMLBJ()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("Waiting to start" + InventoryItemType.Shader.ToString().ToLower(), "_FixDistance");
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "BitsData";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "MenuScene";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Value2" || id == "/";
			if (id == "_Value4")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1974f;
			}
			else if (id == "Particles/Additive")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 594f;
			}
			GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "\nCreated by Oxy949";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "{0:x2}";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Despawn environment object by id";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "SpawnObj";
		}
		if ((bool)GameObject.Find("_Distance") && (bool)GameObject.Find("_TimeX").GetComponentInChildren<Image>())
		{
			GameObject.Find("mapselector.lastSearch").GetComponentInChildren<Image>().enabled = id == "settings.volume.menu";
		}
		KCFOBKNIELP = true;
	}

	public void ALKBNPMCEOM()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GLLNAELOMBK();
		}
	}

	private void FOLDLDLFFLM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NDACFLFLANE();
		}
	}

	private void HIKKPDACJGI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			KIBEDOCDGCG();
		}
	}

	private void FGNFILLNPJK()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DLIGNKPKAOP();
		}
	}

	private void NKMAIAJDLHB()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("RestartButton" + InventoryItemType.Other.ToString().ToLower(), "checkpoint");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == ";";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "MapEditorScene";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "blue" || id == "SetParticlesColor";
			if (id == "Editor/")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1987f;
			}
			else if (id == "Down")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1290f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "HandsCountSlider";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "LostLive";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Item invalid. Make sure your mod contains at leats one file.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "907198288";
		}
		if ((bool)GameObject.Find("_Distortion") && (bool)GameObject.Find("MusicFileSelector").GetComponentInChildren<Image>())
		{
			GameObject.Find("CameraFilterPack_Blizzard1").GetComponentInChildren<Image>().enabled = id == "SAVE";
		}
		KCFOBKNIELP = false;
	}

	private void DBONMCBDEPG()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_TimeX" + ((InventoryItemType)6).ToString().ToLower(), "_Visualize");
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == " url: ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "IconImage";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "[ResourcesManager] Unloading data resources") && id == "CameraFilterPack/BlurHole";
			if (id == "LeaderboardsButton")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 499f;
			}
			else if (id == ".GoalProgress")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 107f;
			}
			GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == ".played";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "<b>";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == ": ";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == ").png";
		}
		if ((bool)GameObject.Find("_ScreenResolution") && (bool)GameObject.Find("event").GetComponentInChildren<Image>())
		{
			GameObject.Find("loadscene").GetComponentInChildren<Image>().enabled = id == "_Vignetting";
		}
		KCFOBKNIELP = false;
	}

	private void PKDDPFLCAHI()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("Lag " + ((InventoryItemType)6).ToString().ToLower(), "_Value");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "UI Extensions/UILinearDodge";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "ResourceIDInputField";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "#changenote") && id == "FullscreenToggle";
			if (id == "_Value2")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1209f;
			}
			else if (id == "menu.tabid")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1969f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_Offsets";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "CameraFilterPack/Blend2Camera_ColorDodge";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == " cannot be used as a 3D LUT.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_BlurVector";
		}
		if ((bool)GameObject.Find("_Intensity") && (bool)GameObject.Find("ReconnectToMaster() with AuthValues == null is not correct!").GetComponentInChildren<Image>())
		{
			GameObject.Find("a").GetComponentInChildren<Image>().enabled = id == "#newhighscore";
		}
		KCFOBKNIELP = false;
	}

	public void FAIMAGILFLO()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GDPOFILIMJB();
		}
	}

	private void HMNLHMLILKD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PLKGKBPAIOP();
		}
	}

	private void POJFHDFJOPE()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			OOHLEMKHNKJ();
		}
	}

	private void LMADKINICIN()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PNLBMKHFPEA();
		}
	}

	private void FABKIGNFECE()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JOMJICOMCEK();
		}
	}

	private void DEPPOJEPCJC()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_TimeX" + InventoryItemType.Shader.ToString().ToLower(), "CameraFilterPack/Color_Sepia");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "clear";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Editor";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "MascotChallenge2019" || id == "float,0";
			if (id == "#finished")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1560f;
			}
			else if (id == "Mouse X")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1914f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "CHROMATIC_ABERRATION";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "[Right]";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Subscribed cells:\n";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == ".";
		}
		if ((bool)GameObject.Find("_Value2") && (bool)GameObject.Find(" to: ").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value2").GetComponentInChildren<Image>().enabled = id == "_LightIntensity";
		}
		KCFOBKNIELP = true;
	}

	public void LCKKDMKJJEF()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DBONMCBDEPG();
		}
	}

	public void BKEFJPOHKDE()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			MDACKFPPNAE();
		}
	}

	private void GHILDCBCDJI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ALGHFMOEINN();
		}
	}

	private void LJLKKJEFFLK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("Preparing content..." + ((InventoryItemType)5).ToString().ToLower(), "_ScreenResolution");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "SetSatelliteEmission";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "music";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "finished" || id == "CameraFilterPack/Noise_TV_2";
			if (id == "_ScreenResolution")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1727f;
			}
			else if (id == "_Intensity")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 318f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_MainTex2";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "\"";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Editor";
		}
		if ((bool)GameObject.Find("/?player=") && (bool)GameObject.Find("_FilteredReflections").GetComponentInChildren<Image>())
		{
			GameObject.Find("challenges/").GetComponentInChildren<Image>().enabled = id == "Reading preview file failed!: \"{0}\"";
		}
		KCFOBKNIELP = false;
	}

	public void BOMFGAMNHIE()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GLLNAELOMBK();
		}
	}

	public void EOPEMLDJAAO()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GLLNAELOMBK();
		}
	}

	private void GPFJMKCGHGB()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ALGHFMOEINN();
		}
	}

	private void LDDKCCMHMIC()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DEBPOMCFBJO();
		}
	}

	public void OCHADIJNDJK()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			MDACKFPPNAE();
		}
	}

	public void LILOGPDPFDA()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			MDACKFPPNAE();
		}
	}

	private void AGMEELGLEEE()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE(" This is not possible to be called for standalone input. Please check your platform and code where this is called" + InventoryItemType.Shader.ToString().ToLower(), "Editor/");
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == ".jpg";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "CameraFilterPack/Blend2Camera_LinearDodge";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_RandomTexture" || id == "/../";
			if (id == "ItemNameText")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1513f;
			}
			else if (id == "PlayButton")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 557f;
			}
			GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == " has been disabled as it's not supported on the current platform.";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "Triangle";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_ReflectionBlur";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "0,1,false";
		}
		if ((bool)GameObject.Find("FinalScoreSmallText") && (bool)GameObject.Find("_Value2").GetComponentInChildren<Image>())
		{
			GameObject.Find("FinalScoreText").GetComponentInChildren<Image>().enabled = id == "CameraFilterPack/FX_ZebraColor";
		}
		KCFOBKNIELP = true;
	}

	private void HJPEHBPMPEK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("player.licenceaccepted" + InventoryItemType.MenuTheme.ToString().ToLower(), "Color's hex value #RRGGBBAA");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "Could not execute RPC ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "HandsCountSlider";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "FinalScoreSmallText" || id == "_Value";
			if (id == "PossibleMapPointsText")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 920f;
			}
			else if (id == "_Value2")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1428f;
			}
			GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "PUNCloudBestRegion";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == " not exist";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "[EditorEvent] Exception: ";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Data/Maps/";
		}
		if ((bool)GameObject.Find("Drop_With_Obj") && (bool)GameObject.Find("Noise shaders are not set up! Disabling noise effect.").GetComponentInChildren<Image>())
		{
			GameObject.Find("_TimeX").GetComponentInChildren<Image>().enabled = id == "sfxVolume";
		}
		KCFOBKNIELP = false;
	}

	private void IEMEHGCFAPD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LAGGOOCMLBJ();
		}
	}

	private void MOABIEIPGHN()
	{
		string s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("[Singleton] An instance of '" + InventoryItemType.MenuTheme.ToString().ToLower(), "SelectorMusicToggle");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "-1";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Tab2Content";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "OpGetGameList not sent. Lobby cannot be null." || id == "visible";
			if (id == "SetSunInput")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1105f;
			}
			else if (id == "Gameplay/Base")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 138f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[NetworkManager] Connected to ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "settings.gamemessagesduration";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_TimeX";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "CameraFilterPack/Blend2Camera_Subtract";
		}
		if ((bool)GameObject.Find(".lastCheckpoint.bgcolor") && (bool)GameObject.Find("_Value2").GetComponentInChildren<Image>())
		{
			GameObject.Find("CameraFilterPack/Drawing_BluePrint").GetComponentInChildren<Image>().enabled = id == "MapFolderInputField";
		}
		KCFOBKNIELP = true;
	}

	public void GCNKIJDNPMD()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKDDPFLCAHI();
		}
	}

	private void KMKLDAJLCNM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DEPPOJEPCJC();
		}
	}

	private void ALGHFMOEINN()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_MainTex2" + InventoryItemType.Other.ToString().ToLower(), "_Value");
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_FresnelFade";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == " ";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Near" || id == "_Value4";
			if (id == "_Far")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1346f;
			}
			else if (id == "Set particles gravity")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1079f;
			}
			GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "Hex value #RRGGBB";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "LowMid";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Value4";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "[PlayerController] ";
		}
		if ((bool)GameObject.Find("_Distance") && (bool)GameObject.Find("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End").GetComponentInChildren<Image>())
		{
			GameObject.Find("z").GetComponentInChildren<Image>().enabled = id == "_Distortion";
		}
		KCFOBKNIELP = true;
	}

	private void ABBNNMHMLOI()
	{
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("0.00" + InventoryItemType.Other.ToString().ToLower(), "JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.");
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_LightIntensity";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Deleted event";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Created") && id == "#pleasewait";
			if (id == "ItemsStoreButton")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1135f;
			}
			else if (id == "Editor/")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 562f;
			}
			GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[Up]";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_Distortion";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "#later";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_TimeX";
		}
		if ((bool)GameObject.Find("_TimeX") && (bool)GameObject.Find("ResourcesConfig").GetComponentInChildren<Image>())
		{
			GameObject.Find("#").GetComponentInChildren<Image>().enabled = id == "https://www.youtube.com/watch?v=cDVXukrKo74";
		}
		KCFOBKNIELP = false;
	}

	private void BGDONBMDPGM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ABBNNMHMLOI();
		}
	}

	private void LCJHDLKJEOM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PNLBMKHFPEA();
		}
	}

	private void HPNNCNNFMGK()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NKMAIAJDLHB();
		}
	}

	public void AOEEOKNJDCK()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKOINEADGNA();
		}
	}

	private void GDPOFILIMJB()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("SaveButton" + InventoryItemType.MenuTheme.ToString().ToLower(), "error");
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_Value";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "SetSunDirectionVector";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "UndoButton" || id == "Joystick1Button10";
			if (id == "[RanksSystem] Ranks: no need to update")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1415f;
			}
			else if (id == "CameraFilterPack/Colors_HUE_Rotate")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1202f;
			}
			GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "?";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "OpAuthenticate()";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Default UI Material";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "note.0";
		}
		if ((bool)GameObject.Find("Result for ") && (bool)GameObject.Find("/").GetComponentInChildren<Image>())
		{
			GameObject.Find("<b>Difficulty</b>:").GetComponentInChildren<Image>().enabled = id == "_TimeX";
		}
		KCFOBKNIELP = true;
	}

	private void JBNPEHMDCMI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LAGGOOCMLBJ();
		}
	}

	public void MDPJHKECLOF()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			KIBEDOCDGCG();
		}
	}

	public void PIEPPKMBJHI()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GDJNNMGCGGK();
		}
	}

	public void FCKLLMEPONC()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PNLBMKHFPEA();
		}
	}

	public void FEJAAGGMBOE()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DKLJCAINIDG();
		}
	}

	private void EJFJENFKLND()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LAGGOOCMLBJ();
		}
	}

	public void PMAGMPCMGPB()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NKMAIAJDLHB();
		}
	}
}
