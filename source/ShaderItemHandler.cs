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

	private void AGMEELGLEEE()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("DISTORT" + InventoryItemType.MenuTheme.ToString().ToLower(), "_Value7");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(@string)).item.id;
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
			GetComponent<Chunky>().enabled = id == "AddEnvironmentObject";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "\nCreated by Oxy949" || id == "_Vignetting2";
			if (id == "settings_bindings_controller_type")
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
			GetComponent<ColorCorrectionCurves>().PIKAHEBPPCN();
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
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Offsets";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_Value5";
		}
		if ((bool)GameObject.Find("_PColor2") && (bool)GameObject.Find("#ok").GetComponentInChildren<Image>())
		{
			GameObject.Find("_FixDistance").GetComponentInChildren<Image>().enabled = id == "ticket";
		}
		KCFOBKNIELP = false;
	}

	private void NEFPMLNOBJF()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH(" This is not possible to be called for standalone input. Please check your platform and code where this is called" + InventoryItemType.Shader.ToString().ToLower(), "Editor/");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "[ResourcesManager] Load image error: ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Axis" || id == "/../";
			if (id == "ItemsCountText")
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
			GetComponent<ColorCorrectionCurves>().PIKAHEBPPCN();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == " should be overwritten.";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "Circle";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_PixelsPerMeterAtOneMeter";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "green";
		}
		if ((bool)GameObject.Find("FinalScoreSmallText") && (bool)GameObject.Find("_Value1").GetComponentInChildren<Image>())
		{
			GameObject.Find("FinalScoreText").GetComponentInChildren<Image>().enabled = id == "_ScreenResolution";
		}
		KCFOBKNIELP = true;
	}

	public void AEIMOFGABJG()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JOMJICOMCEK();
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

	private void HNDNDPECBPL()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JMFMKCDKGHK();
		}
	}

	public void EKOAKKNGGGI()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			AAOIFFIKMMF();
		}
	}

	private void BEPABLJNPOE()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("_Speed" + InventoryItemType.Other.ToString().ToLower(), "_TimeX");
		string id = Singleton<ItemsHandler>.Instance.GDFGIJKLCBA(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_LayerThickness";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "rd";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Near" || id == "_Value3";
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
			GetComponent<ColorCorrectionCurves>().NNAGLFMBDMI();
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
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Value3";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == " not exist";
		}
		if ((bool)GameObject.Find("_Distance") && (bool)GameObject.Find(" ").GetComponentInChildren<Image>())
		{
			GameObject.Find("z").GetComponentInChildren<Image>().enabled = id == "CameraFilterPack/TV_Vintage";
		}
		KCFOBKNIELP = true;
	}

	public void ODFOEENHKCO()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			IJHMDODAGBC();
		}
	}

	private void KMKLDAJLCNM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NEFPMLNOBJF();
		}
	}

	public void NOMLFPFGFBI()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GMOMHPDHJIG();
		}
	}

	private void FOMNCPKKCFN()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ECHNKPKOCEJ();
		}
	}

	private void GDJNNMGCGGK()
	{
		string s = Singleton<SaveSystem>.Instance.KNOIENOFCIB("ws://" + InventoryItemType.Player.ToString().ToLower(), "Network destroy Instantiated GO: ");
		string id = Singleton<ItemsHandler>.Instance.GDFGIJKLCBA(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == " ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "[PlayerBase] Saveing checkpoint data";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "RestartButton") && id == "_Value4";
			if (id == "https://reddit.com/r/Intralism")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 993f;
			}
			else if (id == ".sav")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 858f;
			}
			GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "#{0:X2}{1:X2}{2:X2}";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "Can't set visible when not in that room.";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == ". Check if the server is available.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "UI Extensions/UIMultiply";
		}
		if ((bool)GameObject.Find("The image effect ") && (bool)GameObject.Find("CameraFilterPack/FX_Hexagon").GetComponentInChildren<Image>())
		{
			GameObject.Find("Using constructor for new PingNativeDynamic()").GetComponentInChildren<Image>().enabled = id == "_OcclusionTexture";
		}
		KCFOBKNIELP = true;
	}

	private void Update()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			FHADLGLMIBG();
		}
	}

	public void GINPIKEJGJD()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JMFMKCDKGHK();
		}
	}

	private void ICHIEGLKMLJ()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("Bad parameters for getbool! Use <key> <value>" + InventoryItemType.Shader.ToString().ToLower(), "Failed to 'network-remove' GameObject because it's null.");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == " is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == " left";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Source: ") && id == "SetRotation";
			if (id == "<b>#")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 372f;
			}
			else if (id == "workshop.")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1654f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == ",0";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "#reward: ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "OneHand";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "<b>#banended</b>";
		}
		if ((bool)GameObject.Find("settings.shaders.bloomintencity") && (bool)GameObject.Find("_Value2").GetComponentInChildren<Image>())
		{
			GameObject.Find("/icon").GetComponentInChildren<Image>().enabled = id == "GlassDistortion";
		}
		KCFOBKNIELP = true;
	}

	private void GMELGGJOPBB()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			BEPABLJNPOE();
		}
	}

	private void JOMJICOMCEK()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("_TimeX" + ((InventoryItemType)6).ToString().ToLower(), "_FixDistance");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "settings.customdataskin";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_Value1";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == ",viewkeys") && id == "CameraFilterPack/BlurHole";
			if (id == "LeaderboardsButton")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 499f;
			}
			else if (id == ".icon")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 107f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "BadgeText";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "<b>";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "[PlayerController] ";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == ".png";
		}
		if ((bool)GameObject.Find("_ScreenResolution") && (bool)GameObject.Find("event").GetComponentInChildren<Image>())
		{
			GameObject.Find("Print the list of scenes, avalable in game.").GetComponentInChildren<Image>().enabled = id == "Vignette";
		}
		KCFOBKNIELP = false;
	}

	private void HLDFOJMHKNL()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NDELGDNBJJM();
		}
	}

	private void JHPOIOELNCG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CMHJMGBCFKG();
		}
	}

	private void IEMEHGCFAPD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ECOKPFOMLMC();
		}
	}

	private void MDACKFPPNAE()
	{
		string s = Singleton<SaveSystem>.Instance.KNOIENOFCIB("/" + ((InventoryItemType)8).ToString().ToLower(), "_Gamma");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == ":";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == " Server: ";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "SUCCESS! Item submitted! :D :D :D") && id == "#TBD";
			if (id == "_Value4")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1413f;
			}
			else if (id == "inventory.selected.")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1944f;
			}
			GetComponent<ColorCorrectionCurves>().IBJHOKDDNBL();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "Items/";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_Value5";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "DestroyRpc";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "[PlayerBase] New highscore";
		}
		if ((bool)GameObject.Find("_Parasite") && (bool)GameObject.Find(" is set to dontSave = true, continuing loop.").GetComponentInChildren<Image>())
		{
			GameObject.Find("_MainTex2").GetComponentInChildren<Image>().enabled = id == "note.7";
		}
		KCFOBKNIELP = false;
	}

	public void ALGKENJGNLL()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NDELGDNBJJM();
		}
	}

	private void MECJHOJPODB()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKDDPFLCAHI();
		}
	}

	private void AAOIFFIKMMF()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("," + InventoryItemType.MenuTheme.ToString().ToLower(), "Set satellite MinVertexDistance - how much distance should be between to points of the trail line");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "Use ticket: ";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Overlay";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "_ScreenResolution") && id == "menu.selectedmode";
			if (id == "Save the map before exiting?")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1650f;
			}
			else if (id == "_Speed")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 11f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "HiddenToggle";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_Extra2";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Bloom1";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End";
		}
		if ((bool)GameObject.Find("ConnectionTimeout") && (bool)GameObject.Find("FileMenu").GetComponentInChildren<Image>())
		{
			GameObject.Find("checkpoint").GetComponentInChildren<Image>().enabled = id == "ScoreText";
		}
		KCFOBKNIELP = true;
	}

	private void POIOPIDDNJH()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("PS Home" + InventoryItemType.Other.ToString().ToLower(), "\"\"");
		string id = Singleton<ItemsHandler>.Instance.GDFGIJKLCBA(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "QuickSave";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == " != ";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Change Note:") && id == "health";
			if (id == " not exist")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 837f;
			}
			else if (id == "_TimeX")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 350f;
			}
			GetComponent<ColorCorrectionCurves>().ELFFJGJKDBG();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == ":";
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
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Couldn't color correct with 3D LUT texture. Image Effect will be disabled.";
		}
		if ((bool)GameObject.Find("Mouse2") && (bool)GameObject.Find("settings_bindings_").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value2").GetComponentInChildren<Image>().enabled = id == "init";
		}
		KCFOBKNIELP = true;
	}

	private void GPNAJHDFIFF()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH(".lastCheckpoint.isMapCompleted" + InventoryItemType.MenuTheme.ToString().ToLower(), "_TimeX");
		string id = Singleton<ItemsHandler>.Instance.GDFGIJKLCBA(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "InventoryButton";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "_Value2") && id == "76561198041679481";
			if (id == "Multiplayer")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 699f;
			}
			else if (id == "_Value")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 868f;
			}
			GetComponent<ColorCorrectionCurves>().ELFFJGJKDBG();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "LoadingStatusText";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "GridDataStoryboard";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "event";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_AlphaHexa";
		}
		if ((bool)GameObject.Find("th") && (bool)GameObject.Find("Error: I/O Failure! :(").GetComponentInChildren<Image>())
		{
			GameObject.Find("_TimeX").GetComponentInChildren<Image>().enabled = id == "_Green_R";
		}
		KCFOBKNIELP = true;
	}

	public void OCHADIJNDJK()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GDJNNMGCGGK();
		}
	}

	private void BMODOIJGIOO()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LKBBGBBEJKP();
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

	private void PKOINEADGNA()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("In Network lobby" + InventoryItemType.Shader.ToString().ToLower(), "_FixDistance");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
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
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Value2" || id == " ";
			if (id == "_Value3")
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
			GetComponent<ColorCorrectionCurves>().NNAGLFMBDMI();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "/files/editor_manual.pdf";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "[SteamManager] Connecting to server";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Case-Sensitive";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == ".lastCheckpoint.bgcolor";
		}
		if ((bool)GameObject.Find("_Distance") && (bool)GameObject.Find("CameraFilterPack/TV_Posterize").GetComponentInChildren<Image>())
		{
			GameObject.Find("PopulateMapsList").GetComponentInChildren<Image>().enabled = id == "Scene";
		}
		KCFOBKNIELP = true;
	}

	public void PIEPPKMBJHI()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			AAOIFFIKMMF();
		}
	}

	private void IJHMDODAGBC()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("Tab2Content" + InventoryItemType.Ticket.ToString().ToLower(), ". Using max value: 255.");
		string id = Singleton<ItemsHandler>.Instance.GDFGIJKLCBA(ulong.Parse(@string)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "EventTimeInputField";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "skin.";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "Gameplay/Base" || id == "_Value";
			if (id == "#loopnumber ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 192f;
			}
			else if (id == "CameraFilterPack/Blend2Camera_Subtract")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1190f;
			}
			GetComponent<ColorCorrectionCurves>().IBJHOKDDNBL();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_Value";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "CameraFilterPack/Drawing_BluePrint";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "MusicFileSelector";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Maps Editor v.";
		}
		if ((bool)GameObject.Find("key") && (bool)GameObject.Find("ConfigVersionSlider").GetComponentInChildren<Image>())
		{
			GameObject.Find(" [").GetComponentInChildren<Image>().enabled = id == "_ScreenResolution";
		}
		KCFOBKNIELP = false;
	}

	public void LBICLFNOLAK()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NEFPMLNOBJF();
		}
	}

	private void LCHBFNIPBHB()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			KBLLBKNNBGO();
		}
	}

	private void PKDDPFLCAHI()
	{
		string s = Singleton<SaveSystem>.Instance.KNOIENOFCIB("_ToPrevViewProjCombined" + InventoryItemType.Shader.ToString().ToLower(), "R1");
		string id = Singleton<ItemsHandler>.Instance.IKNFGEBCENH(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "GlassDistortion";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "_ScreenResolution") && id == "Error; Only the MasterClient can call RemoveRPCs for other players.";
			if (id == "maphash")
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
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[LevelEditorScene] Map submitted!";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "menu.selectedplaymode";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Value2";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "CameraFilterPack/FX_Drunk2";
		}
		if ((bool)GameObject.Find(" canvas not found") && (bool)GameObject.Find("[MapEditor] Updating top menu").GetComponentInChildren<Image>())
		{
			GameObject.Find("\n").GetComponentInChildren<Image>().enabled = id == "/";
		}
		KCFOBKNIELP = true;
	}

	private void NFEDLAOPHML()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LJLKKJEFFLK();
		}
	}

	private void JMFMKCDKGHK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("skin." + ((InventoryItemType)8).ToString().ToLower(), "ticket");
		string id = Singleton<ItemsHandler>.Instance.GDFGIJKLCBA(ulong.Parse(s)).item.id;
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
			GetComponent<Chunky>().enabled = id == "/";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Parent object ID. Case-Sensitive") && id == "Most likely the game became empty during the switch to GameServer.";
			if (id == "_OcclusionBlurTexture")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 119f;
			}
			else if (id == "_ScreenResolution")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 935f;
			}
			GetComponent<ColorCorrectionCurves>().ELFFJGJKDBG();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "\n";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Value3";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "settings.volume.game";
		}
		if ((bool)GameObject.Find("_Distortion") && (bool)GameObject.Find("input").GetComponentInChildren<Image>())
		{
			GameObject.Find("shader.future").GetComponentInChildren<Image>().enabled = id == "Jul";
		}
		KCFOBKNIELP = false;
	}

	public void LCGMHCBNCDM()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GAFPJCJIONB();
		}
	}

	private void PIFCELNDGPM()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_HSV" + InventoryItemType.Ticket.ToString().ToLower(), "]. Please verify you have this gameobject in a Resources folder.");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "Show Title";
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
			GetComponent<ColorCorrectionCurves>().enabled = !(id == ",") && id == "_Size";
			if (id == "settings.crosshairopacity")
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
			GetComponent<ColorCorrectionCurves>().IBJHOKDDNBL();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[ItemsHandler] Found ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "mapselector.filter.subscribedonly";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Value";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "SpawnObj";
		}
		if ((bool)GameObject.Find("_TimeX") && (bool)GameObject.Find(" cannot be used as a 3D LUT.").GetComponentInChildren<Image>())
		{
			GameObject.Find("_TimeX").GetComponentInChildren<Image>().enabled = id == "CameraFilterPack/FX_Ascii";
		}
		KCFOBKNIELP = false;
	}

	public void KOKDPAEJECC()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			FHADLGLMIBG();
		}
	}

	public void PMAGMPCMGPB()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ECHNKPKOCEJ();
		}
	}

	private void JDGFCEPDKAJ()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DEPPOJEPCJC();
		}
	}

	public void PFMJPIJONIP()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			ICHIEGLKMLJ();
		}
	}

	private void COGBDFKOHKK()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GPNAJHDFIFF();
		}
	}

	private void MDCFIHDPLIG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			KBLLBKNNBGO();
		}
	}

	private void LKBBGBBEJKP()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("CameraFilterPack/Atmosphere_Rain_Pro" + InventoryItemType.Other.ToString().ToLower(), "shader.crispwinter");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_EmissionColor";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Failed to Instantiate prefab: ";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Value" || id == "menu.tabid";
			if (id == "[PlayerController] ")
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
			GetComponent<ColorCorrectionCurves>().IBJHOKDDNBL();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "{0:0}";
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
		if ((bool)GameObject.Find("Mouse2") && (bool)GameObject.Find("NEW").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Amount").GetComponentInChildren<Image>().enabled = id == "Set EnvSprite Image";
		}
		KCFOBKNIELP = false;
	}

	public void FECMEIJGLJI()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			KBLLBKNNBGO();
		}
	}

	private void OPCLBGHAPMG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			BEPABLJNPOE();
		}
	}

	private void KBDFEKCBFOP()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString(" not exist" + InventoryItemType.MenuTheme.ToString().ToLower(), "Set Particles Emission");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(@string)).item.id;
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
			GetComponent<ColorCorrectionCurves>().enabled = id == "_DistortionWave" || id == "EventMenu";
			if (id == "_ScreenResolution")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1633f;
			}
			else if (id == "id")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1914f;
			}
			GetComponent<ColorCorrectionCurves>().ELFFJGJKDBG();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "setint";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GameObject.Find("SetSunMinSize") && (bool)GameObject.Find("Tab2Content").GetComponentInChildren<Image>())
		{
			GameObject.Find("player.greenlollipop").GetComponentInChildren<Image>().enabled = id == "steamid";
		}
		KCFOBKNIELP = true;
	}

	private void EHJJFJCKGAJ()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GPNAJHDFIFF();
		}
	}

	public void PAFMNAIDAFH()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			BEPABLJNPOE();
		}
	}

	private void LDDKCCMHMIC()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKOINEADGNA();
		}
	}

	private void KMEONPMCNJG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CMHJMGBCFKG();
		}
	}

	public void ALKBNPMCEOM()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			BEPABLJNPOE();
		}
	}

	private void HMNLHMLILKD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			IKLMKOCJPAH();
		}
	}

	private void DEPPOJEPCJC()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("mapselector.tags." + InventoryItemType.Shader.ToString().ToLower(), "[PlayerController] ");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "challenges.";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_Distortion";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "_Value2" || id == "Creating awesome map";
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
			GetComponent<ColorCorrectionCurves>().PMDNKDOECDO();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "SubmitUserVote:";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_TimeX";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "challenges.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Item invalid. Make sure your mod contains at leats one file.";
		}
		if ((bool)GameObject.Find("https://www.youtube.com/watch?v=cDVXukrKo74") && (bool)GameObject.Find("\\\\").GetComponentInChildren<Image>())
		{
			GameObject.Find("GlassDistortion").GetComponentInChildren<Image>().enabled = id == "CameraFilterPack_VHS1";
		}
		KCFOBKNIELP = false;
	}

	private void LJIHHJOAJCN()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JCIDAMKNHJC();
		}
	}

	public void MOKHHEMAJBJ()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GPNAJHDFIFF();
		}
	}

	public void NKLCNJEIAFB()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			POIOPIDDNJH();
		}
	}

	private void HIKKPDACJGI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			KBLLBKNNBGO();
		}
	}

	private void ONMGIPAILOH()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CMHJMGBCFKG();
		}
	}

	private void HPNLLBIOJNN()
	{
		string s = Singleton<SaveSystem>.Instance.KNOIENOFCIB("player.licenceaccepted" + InventoryItemType.MenuTheme.ToString().ToLower(), "color");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "RPC can't be sent to target PhotonPlayer being null! Did not send \"";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "EnvironmentSlider";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "FinalScoreSmallText" || id == "_Value";
			if (id == "HightScoreMaxPointsText")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 920f;
			}
			else if (id == "_Value")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1428f;
			}
			GetComponent<ColorCorrectionCurves>().IBJHOKDDNBL();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "Error: you cannot write/send to this stream that you are reading!";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == ": ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "[EditorEvent] Exception: ";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == " base map(s)";
		}
		if ((bool)GameObject.Find("Drop_With_Obj") && (bool)GameObject.Find("_NoiseTex").GetComponentInChildren<Image>())
		{
			GameObject.Find("_MainTex2").GetComponentInChildren<Image>().enabled = id == "menuVolume";
		}
		KCFOBKNIELP = false;
	}

	private void KIBEDOCDGCG()
	{
		string s = Singleton<SaveSystem>.Instance.KNOIENOFCIB(".lastCheckpoint.bgcolor" + InventoryItemType.Player.ToString().ToLower(), "CameraFilterPack/Color_BrightContrastSaturation");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Sending RPC \"";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "ItemNameBGImage" || id == "_ScreenResolution";
			if (id == "_TimeX")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 551f;
			}
			else if (id == "_Far")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1813f;
			}
			GetComponent<ColorCorrectionCurves>().JMDPECLHOPJ();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_MainTex2";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "BadgeText";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_ScreenSize";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Bad parameters for getbool! Use <key> <value>";
		}
		if ((bool)GameObject.Find("Editor/") && (bool)GameObject.Find(".lastCheckpoint.comboScore").GetComponentInChildren<Image>())
		{
			GameObject.Find(" isOwnerActive: ").GetComponentInChildren<Image>().enabled = id == "uploads/Intralism/mods_terms.pdf";
		}
		KCFOBKNIELP = true;
	}

	public void LLAHPNGMEOO()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			AAOIFFIKMMF();
		}
	}

	private void JAAJECBCCFM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JAIGGHHGOGA();
		}
	}

	private void JCIDAMKNHJC()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("SaveButton" + InventoryItemType.MenuTheme.ToString().ToLower(), "ticket");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_TimeX";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Set sun min/max size";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "checkpoint" || id == "Joystick1Button9";
			if (id == "Connection error: ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1415f;
			}
			else if (id == "_Val")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1202f;
			}
			GetComponent<ColorCorrectionCurves>().ELFFJGJKDBG();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "?";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "UI Extensions/UIScreen";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "|";
		}
		if ((bool)GameObject.Find("Bad parameters for getint! Use <key> <value>") && (bool)GameObject.Find("IconFileSelector").GetComponentInChildren<Image>())
		{
			GameObject.Find("--------------------------------").GetComponentInChildren<Image>().enabled = id == "CameraFilterPack/TV_Horror";
		}
		KCFOBKNIELP = true;
	}

	public void LILOGPDPFDA()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GDJNNMGCGGK();
		}
	}

	private void CMHJMGBCFKG()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("player.playedtutorial" + ((InventoryItemType)6).ToString().ToLower(), "_Near");
		string id = Singleton<ItemsHandler>.Instance.IKNFGEBCENH(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "[Right-Down]";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "EventSystem";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "settings.fps") && id == "_Value";
			if (id == "mapselector.tags.")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 688f;
			}
			else if (id == "PUNCloudBestRegion")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 334f;
			}
			GetComponent<ColorCorrectionCurves>().IBJHOKDDNBL();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "Creating new item...";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "|";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_Value2";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "settings.enablehitsoundsinrelax";
		}
		if ((bool)GameObject.Find("Submition failed") && (bool)GameObject.Find("inventory.itemscash").GetComponentInChildren<Image>())
		{
			GameObject.Find("Tab2Content").GetComponentInChildren<Image>().enabled = id == "/";
		}
		KCFOBKNIELP = true;
	}

	private void NDELGDNBJJM()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("_Blue_R" + ((InventoryItemType)6).ToString().ToLower(), "UI Extensions/UISoftAdditive");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == ",";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "_Value4") && id == "/icon";
			if (id == "_Value2")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 975f;
			}
			else if (id == "PunRespawn")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1668f;
			}
			GetComponent<ColorCorrectionCurves>().NNAGLFMBDMI();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "ShadersToggle";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "SaveButton";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "maps.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "CameraFilterPack/Color_BrightContrastSaturation";
		}
		if ((bool)GameObject.Find("_TimeX") && (bool)GameObject.Find("_ScreenResolution").GetComponentInChildren<Image>())
		{
			GameObject.Find("MapEnd").GetComponentInChildren<Image>().enabled = id == "shader.ghost";
		}
		KCFOBKNIELP = true;
	}

	public void CDDHLFNJOGC()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LKBBGBBEJKP();
		}
	}

	private void GMOMHPDHJIG()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_Value3" + InventoryItemType.MenuTheme.ToString().ToLower(), "<b>#");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "[Singleton] multiple instances of '";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_NeighbourMaxTex";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "ERROR You should never change PhotonPlayer IDs!") && id == "Rtt:{0,4} +/-{1,3}";
			if (id == "_TimeX")
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
			GetComponent<ColorCorrectionCurves>().PMDNKDOECDO();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[MapEditor] Importing map: ";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "#tryagain";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "move";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == " ";
		}
		if ((bool)GameObject.Find(" not exist") && (bool)GameObject.Find("_TexelOffsetScale").GetComponentInChildren<Image>())
		{
			GameObject.Find("_ScreenResolution").GetComponentInChildren<Image>().enabled = id == "seconds";
		}
		KCFOBKNIELP = false;
	}

	private void IKLMKOCJPAH()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_ScreenResolution" + ((InventoryItemType)7).ToString().ToLower(), "<b>");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "_Value3";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "_Value2";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "float,0") && id == "CameraFilterPack/Vision_Rainbow";
			if (id == "CameraFilterPack/TV_Distorted")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1235f;
			}
			else if (id == "colorC")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 401f;
			}
			GetComponent<ColorCorrectionCurves>().IBJHOKDDNBL();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "SpawnObj";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "LT";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_TimeX";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "menuVolume";
		}
		if ((bool)GameObject.Find("_FadeFX") && (bool)GameObject.Find("Gameplay/Segment-[PowerUp]").GetComponentInChildren<Image>())
		{
			GameObject.Find("_FgOverlap").GetComponentInChildren<Image>().enabled = id == "X";
		}
		KCFOBKNIELP = true;
	}

	public void GGHCMPKGNGE()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			DEPPOJEPCJC();
		}
	}

	public void CFNDDGFGKKG()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			LJLKKJEFFLK();
		}
	}

	private void ECOKPFOMLMC()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("GameScene" + ((InventoryItemType)8).ToString().ToLower(), "UI Extensions/UIAdditive");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "bans.viewed.";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = true;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "???";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "ShadersToggle") && id == "_DotSize";
			if (id == "Ignored PU RPC, cause item is inactive. ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 660f;
			}
			else if (id == "Texture2")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 701f;
			}
			GetComponent<ColorCorrectionCurves>().KIOEEAALJHO();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "EnableRankingToggle";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "InputField";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "_CenterX";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "Done! You are a contributor until: ";
		}
		if ((bool)GameObject.Find("CameraFilterPack/FX_InverChromiLum") && (bool)GameObject.Find("_SecondTex").GetComponentInChildren<Image>())
		{
			GameObject.Find("w").GetComponentInChildren<Image>().enabled = id == "_Distortion";
		}
		KCFOBKNIELP = false;
	}

	private void IBHACCEEFFI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GMOMHPDHJIG();
		}
	}

	private void JAIGGHHGOGA()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("No peer to communicate with. " + ((InventoryItemType)6).ToString().ToLower(), "_Value");
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(@string)).item.id;
		if ((bool)GetComponent<InvertColors>())
		{
			GetComponent<InvertColors>().enabled = id == "Please attach component to a Graphical UI component";
		}
		if ((bool)GetComponent<LensAberrations>())
		{
			GetComponent<LensAberrations>().enabled = false;
		}
		if ((bool)GetComponent<Chunky>())
		{
			GetComponent<Chunky>().enabled = id == "Working.\nPlease wait..";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "#mapmustbecompletebeforesubmit") && id == "FullscreenToggle";
			if (id == "_Value")
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
			GetComponent<ColorCorrectionCurves>().IPICDMGDKCK();
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
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "The given 2D texture ";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_OcclusionBlurTexture";
		}
		if ((bool)GameObject.Find("_Intensity") && (bool)GameObject.Find("ns.exitgames.com").GetComponentInChildren<Image>())
		{
			GameObject.Find("g").GetComponentInChildren<Image>().enabled = id == "#newhighscore";
		}
		KCFOBKNIELP = false;
	}

	public void EMOCEKPLGBK()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			NEFPMLNOBJF();
		}
	}

	private void ECHNKPKOCEJ()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("0.00" + InventoryItemType.Other.ToString().ToLower(), "JoinRoom failed. In offline mode you still have to leave a room to enter another.");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
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
			GetComponent<Chunky>().enabled = id == "PLEASE WAIT";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "/") && id == "Editor/";
			if (id == "ItemsStoreButton")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1135f;
			}
			else if (id == "Data/Editor/leveltemplate")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 562f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "[Up]";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "_TimeX";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Outdated version. Please restart the game to get lastest updates.";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "_ScreenResolution";
		}
		if ((bool)GameObject.Find("_TimeX") && (bool)GameObject.Find("MapEditor v.").GetComponentInChildren<Image>())
		{
			GameObject.Find("0x").GetComponentInChildren<Image>().enabled = id == "/files/editor_manual.pdf";
		}
		KCFOBKNIELP = false;
	}

	private void KBLLBKNNBGO()
	{
		string s = Singleton<SaveSystem>.Instance.KNOIENOFCIB("warning: Audio Source: " + ((InventoryItemType)7).ToString().ToLower(), "_ScreenResolution");
		string id = Singleton<ItemsHandler>.Instance.EKLMHNNBOMF(ulong.Parse(s)).item.id;
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
			GetComponent<ColorCorrectionCurves>().enabled = !(id == "Joystick1Button1") && id == "float,1.5";
			if (id == "_Visualize")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1623f;
			}
			else if (id == "Please specify either t or f.")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 288f;
			}
			GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "float,0";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "To Log";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "blue";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "#savemapbeforeuploading";
		}
		if ((bool)GameObject.Find("_TimeX") && (bool)GameObject.Find("<b>#").GetComponentInChildren<Image>())
		{
			GameObject.Find("GroupNameText").GetComponentInChildren<Image>().enabled = id == "true";
		}
		KCFOBKNIELP = false;
	}

	private void PHJJHFBLICM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKDDPFLCAHI();
		}
	}

	private void GAFPJCJIONB()
	{
		string s = Singleton<SaveSystem>.Instance.NBMEANCMGEH("The number of players playing your game: " + ((InventoryItemType)5).ToString().ToLower(), "_TimeX");
		string id = Singleton<ItemsHandler>.Instance.IKNFGEBCENH(ulong.Parse(s)).item.id;
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
			GetComponent<Chunky>().enabled = id == "Editor/";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "ResetButton" || id == "CameraFilterPack_TV_Noise2";
			if (id == "_Value4")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1727f;
			}
			else if (id == "offsets")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 318f;
			}
			GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_Value4";
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
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "maps.";
		}
		if ((bool)GameObject.Find("deletemap") && (bool)GameObject.Find("_ReflectionTexture4").GetComponentInChildren<Image>())
		{
			GameObject.Find("#tryagain").GetComponentInChildren<Image>().enabled = id == "LevelEditor/patterns";
		}
		KCFOBKNIELP = false;
	}

	public void KDJHONILJGK()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JCIDAMKNHJC();
		}
	}

	private void OEENOOGEEHD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			AAOIFFIKMMF();
		}
	}

	private void CLGKDLOAOFG()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("RestartButton" + InventoryItemType.Other.ToString().ToLower(), "BitsData");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(@string)).item.id;
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
			GetComponent<Chunky>().enabled = id == "https://store.steampowered.com/itemstore/513510/";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "blue" || id == "SetParticlesColor";
			if (id == "[MapEditor] Exported to ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1987f;
			}
			else if (id == "Up ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1290f;
			}
			GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "Tab2Content";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "]";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Uploading preview image...";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == "1087340967";
		}
		if ((bool)GameObject.Find("_Cible") && (bool)GameObject.Find("IconFileSelector").GetComponentInChildren<Image>())
		{
			GameObject.Find("CameraFilterPack_Blizzard1").GetComponentInChildren<Image>().enabled = id == " Gb";
		}
		KCFOBKNIELP = false;
	}

	public void KJBJBNGJDAD()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			IJHMDODAGBC();
		}
	}

	public void LMHFEBCKPDI()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			PKDDPFLCAHI();
		}
	}

	public void LDKFAGOEDKF()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CLGKDLOAOFG();
		}
	}

	private void LJLKKJEFFLK()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("CameraFilterPack/Drawing_Manga5" + InventoryItemType.Shader.ToString().ToLower(), "CameraFilterPack/Color_Sepia");
		string id = Singleton<ItemsHandler>.Instance.LDJDALBAPEE(ulong.Parse(@string)).item.id;
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
			GetComponent<Chunky>().enabled = id == "DifficultyBG";
		}
		if ((bool)GetComponent<ColorCorrectionCurves>())
		{
			GetComponent<ColorCorrectionCurves>().enabled = id == "Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(" || id == "value";
			if (id == "#reward: ")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = up;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = down;
				GetComponent<ColorCorrectionCurves>().saturation = 1560f;
			}
			else if (id == "DPADHOR")
			{
				GetComponent<ColorCorrectionCurves>().redChannel = down;
				GetComponent<ColorCorrectionCurves>().greenChannel = down;
				GetComponent<ColorCorrectionCurves>().blueChannel = up;
				GetComponent<ColorCorrectionCurves>().saturation = 1914f;
			}
			GetComponent<ColorCorrectionCurves>().PIKAHEBPPCN();
		}
		if ((bool)GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = id == "_DistCenterScale";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus>())
		{
			GetComponent<CameraFilterPack_Lut_Plus>().enabled = id == "Gameplay/particles";
		}
		if ((bool)GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = id == "Vertical";
		}
		if ((bool)GetComponent<CameraFilterPack_TV_80>())
		{
			GetComponent<CameraFilterPack_TV_80>().enabled = id == ".lastCheckpoint.playerdistance";
		}
		if ((bool)GameObject.Find("_Value2") && (bool)GameObject.Find("Ownership mode == fixed. Ignoring request.").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value").GetComponentInChildren<Image>().enabled = id == "_LightIntensity";
		}
		KCFOBKNIELP = true;
	}

	public void OPKKBMCDOEM()
	{
		KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			JAIGGHHGOGA();
		}
	}

	private void FJHFOBHJEHL()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CMHJMGBCFKG();
		}
	}

	private void DPIPGGDNGHN()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			CLGKDLOAOFG();
		}
	}

	private void FABKIGNFECE()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			IJHMDODAGBC();
		}
	}

	public void PJILLPKFCPO()
	{
		KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			GPNAJHDFIFF();
		}
	}

	private void FABMDEHEDNO()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !KCFOBKNIELP)
		{
			HPNLLBIOJNN();
		}
	}
}
