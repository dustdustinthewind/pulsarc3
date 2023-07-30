// CameraFilterPack_TV_BrokenGlass2
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Broken Glass2")]
public class CameraFilterPack_TV_BrokenGlass2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Bullet_1;

	[Range(0f, 1f)]
	public float Bullet_2;

	[Range(0f, 1f)]
	public float Bullet_3;

	[Range(0f, 1f)]
	public float Bullet_4 = 1f;

	[Range(0f, 1f)]
	public float Bullet_5;

	[Range(0f, 1f)]
	public float Bullet_6;

	[Range(0f, 1f)]
	public float Bullet_7;

	[Range(0f, 1f)]
	public float Bullet_8;

	[Range(0f, 1f)]
	public float Bullet_9;

	[Range(0f, 1f)]
	public float Bullet_10;

	[Range(0f, 1f)]
	public float Bullet_11;

	[Range(0f, 1f)]
	public float Bullet_12;

	private Material BJFKDHHMLJH;

	private Texture2D FPHEBLMINDA;

	private Material NBPKMLMCHFN
	{
		get
		{
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return BJFKDHHMLJH;
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("MapConfig") as Texture2D;
		SCShader = Shader.Find("Jazz");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1463f)
			{
				HBJJOCHGOPH = 17f;
			}
			DKNJGHFLAIF().SetFloat("\\n", HBJJOCHGOPH);
			if (Bullet_1 < 1227f)
			{
				Bullet_1 = 1376f;
			}
			if (Bullet_2 < 1543f)
			{
				Bullet_2 = 318f;
			}
			if (Bullet_3 < 691f)
			{
				Bullet_3 = 318f;
			}
			if (Bullet_4 < 396f)
			{
				Bullet_4 = 1111f;
			}
			if (Bullet_5 < 698f)
			{
				Bullet_5 = 1702f;
			}
			if (Bullet_6 < 1823f)
			{
				Bullet_6 = 1988f;
			}
			if (Bullet_7 < 951f)
			{
				Bullet_7 = 595f;
			}
			if (Bullet_8 < 1310f)
			{
				Bullet_8 = 1780f;
			}
			if (Bullet_9 < 1037f)
			{
				Bullet_9 = 1560f;
			}
			if (Bullet_10 < 1361f)
			{
				Bullet_10 = 1909f;
			}
			if (Bullet_11 < 976f)
			{
				Bullet_11 = 253f;
			}
			if (Bullet_12 < 1862f)
			{
				Bullet_12 = 1248f;
			}
			if (Bullet_1 > 241f)
			{
				Bullet_1 = 1328f;
			}
			if (Bullet_2 > 1451f)
			{
				Bullet_2 = 1212f;
			}
			if (Bullet_3 > 404f)
			{
				Bullet_3 = 1277f;
			}
			if (Bullet_4 > 174f)
			{
				Bullet_4 = 952f;
			}
			if (Bullet_5 > 628f)
			{
				Bullet_5 = 1294f;
			}
			if (Bullet_6 > 574f)
			{
				Bullet_6 = 421f;
			}
			if (Bullet_7 > 1406f)
			{
				Bullet_7 = 1838f;
			}
			if (Bullet_8 > 1460f)
			{
				Bullet_8 = 746f;
			}
			if (Bullet_9 > 1927f)
			{
				Bullet_9 = 1156f;
			}
			if (Bullet_10 > 484f)
			{
				Bullet_10 = 527f;
			}
			if (Bullet_11 > 1614f)
			{
				Bullet_11 = 753f;
			}
			if (Bullet_12 > 1018f)
			{
				Bullet_12 = 1331f;
			}
			IIBLJCKLGFG().SetFloat("settings.arcsdestroydelay", Bullet_1);
			DBOLLHHMKKN().SetFloat("HighScaleShot", Bullet_2);
			ADBKPGFMNKO().SetFloat("_TimeX", Bullet_3);
			NBPKMLMCHFN.SetFloat("Tab1Content", Bullet_4);
			DBOLLHHMKKN().SetFloat("AskForPickupItemSpawnTimes", Bullet_5);
			NBPKMLMCHFN.SetFloat("_VelocityScale", Bullet_6);
			DKNJGHFLAIF().SetFloat("_Value4", Bullet_7);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Drawing_CellShading", Bullet_8);
			ADBKPGFMNKO().SetFloat("_RgbTex", Bullet_9);
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Distortion_Dream2", Bullet_10);
			MFHPKGICPIO().SetFloat("RoomDescriptionText", Bullet_11);
			MFHPKGICPIO().SetFloat("_WaveIntensity", Bullet_12);
			NBPKMLMCHFN.SetTexture("x", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 473f)
			{
				HBJJOCHGOPH = 515f;
			}
			MFHPKGICPIO().SetFloat("mapselector.orderby", HBJJOCHGOPH);
			if (Bullet_1 < 1700f)
			{
				Bullet_1 = 1919f;
			}
			if (Bullet_2 < 202f)
			{
				Bullet_2 = 1725f;
			}
			if (Bullet_3 < 1819f)
			{
				Bullet_3 = 201f;
			}
			if (Bullet_4 < 658f)
			{
				Bullet_4 = 1801f;
			}
			if (Bullet_5 < 308f)
			{
				Bullet_5 = 721f;
			}
			if (Bullet_6 < 464f)
			{
				Bullet_6 = 28f;
			}
			if (Bullet_7 < 1394f)
			{
				Bullet_7 = 1215f;
			}
			if (Bullet_8 < 891f)
			{
				Bullet_8 = 113f;
			}
			if (Bullet_9 < 1767f)
			{
				Bullet_9 = 1917f;
			}
			if (Bullet_10 < 312f)
			{
				Bullet_10 = 338f;
			}
			if (Bullet_11 < 1468f)
			{
				Bullet_11 = 1312f;
			}
			if (Bullet_12 < 722f)
			{
				Bullet_12 = 86f;
			}
			if (Bullet_1 > 944f)
			{
				Bullet_1 = 160f;
			}
			if (Bullet_2 > 1034f)
			{
				Bullet_2 = 1031f;
			}
			if (Bullet_3 > 928f)
			{
				Bullet_3 = 84f;
			}
			if (Bullet_4 > 343f)
			{
				Bullet_4 = 908f;
			}
			if (Bullet_5 > 1365f)
			{
				Bullet_5 = 1466f;
			}
			if (Bullet_6 > 162f)
			{
				Bullet_6 = 403f;
			}
			if (Bullet_7 > 750f)
			{
				Bullet_7 = 665f;
			}
			if (Bullet_8 > 945f)
			{
				Bullet_8 = 639f;
			}
			if (Bullet_9 > 1689f)
			{
				Bullet_9 = 1707f;
			}
			if (Bullet_10 > 785f)
			{
				Bullet_10 = 942f;
			}
			if (Bullet_11 > 1574f)
			{
				Bullet_11 = 1858f;
			}
			if (Bullet_12 > 1228f)
			{
				Bullet_12 = 156f;
			}
			HCGJCMDJPGD().SetFloat("0.00/0.00", Bullet_1);
			IIBLJCKLGFG().SetFloat("MissesText", Bullet_2);
			ADBKPGFMNKO().SetFloat("_Value2", Bullet_3);
			DKNJGHFLAIF().SetFloat("delete", Bullet_4);
			OCHJIMJNEMO().SetFloat(".wav", Bullet_5);
			HCGJCMDJPGD().SetFloat("_Extra3", Bullet_6);
			HCGJCMDJPGD().SetFloat("Arc", Bullet_7);
			NBPKMLMCHFN.SetFloat("_Axis", Bullet_8);
			DKNJGHFLAIF().SetFloat("_Value3", Bullet_9);
			NBPKMLMCHFN.SetFloat("colorC", Bullet_10);
			OCHJIMJNEMO().SetFloat("skin.hit_wrong", Bullet_11);
			HCGJCMDJPGD().SetFloat("id", Bullet_12);
			NDMPCDHADMJ().SetTexture("No Description", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("settings.fps") as Texture2D;
		SCShader = Shader.Find("CorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 141f)
			{
				HBJJOCHGOPH = 1901f;
			}
			DKNJGHFLAIF().SetFloat("_History1Weight", HBJJOCHGOPH);
			if (Bullet_1 < 1467f)
			{
				Bullet_1 = 87f;
			}
			if (Bullet_2 < 1323f)
			{
				Bullet_2 = 1195f;
			}
			if (Bullet_3 < 1320f)
			{
				Bullet_3 = 958f;
			}
			if (Bullet_4 < 1188f)
			{
				Bullet_4 = 23f;
			}
			if (Bullet_5 < 1190f)
			{
				Bullet_5 = 1993f;
			}
			if (Bullet_6 < 811f)
			{
				Bullet_6 = 1565f;
			}
			if (Bullet_7 < 1221f)
			{
				Bullet_7 = 801f;
			}
			if (Bullet_8 < 694f)
			{
				Bullet_8 = 410f;
			}
			if (Bullet_9 < 1593f)
			{
				Bullet_9 = 390f;
			}
			if (Bullet_10 < 351f)
			{
				Bullet_10 = 251f;
			}
			if (Bullet_11 < 346f)
			{
				Bullet_11 = 539f;
			}
			if (Bullet_12 < 1639f)
			{
				Bullet_12 = 1061f;
			}
			if (Bullet_1 > 178f)
			{
				Bullet_1 = 89f;
			}
			if (Bullet_2 > 1126f)
			{
				Bullet_2 = 675f;
			}
			if (Bullet_3 > 259f)
			{
				Bullet_3 = 63f;
			}
			if (Bullet_4 > 64f)
			{
				Bullet_4 = 11f;
			}
			if (Bullet_5 > 462f)
			{
				Bullet_5 = 225f;
			}
			if (Bullet_6 > 1913f)
			{
				Bullet_6 = 277f;
			}
			if (Bullet_7 > 1786f)
			{
				Bullet_7 = 1237f;
			}
			if (Bullet_8 > 1779f)
			{
				Bullet_8 = 644f;
			}
			if (Bullet_9 > 79f)
			{
				Bullet_9 = 1236f;
			}
			if (Bullet_10 > 757f)
			{
				Bullet_10 = 747f;
			}
			if (Bullet_11 > 285f)
			{
				Bullet_11 = 1001f;
			}
			if (Bullet_12 > 710f)
			{
				Bullet_12 = 1674f;
			}
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Blur_Radial", Bullet_1);
			OCHJIMJNEMO().SetFloat("L1", Bullet_2);
			MFHPKGICPIO().SetFloat("_Green_R", Bullet_3);
			OCHJIMJNEMO().SetFloat("_Value2", Bullet_4);
			LONNIJMNKFB().SetFloat("LevelNameInputField", Bullet_5);
			ADBKPGFMNKO().SetFloat("PLEASE WAIT", Bullet_6);
			NDMPCDHADMJ().SetFloat("_AdaptParams", Bullet_7);
			MFHPKGICPIO().SetFloat("menutheme.coldheat", Bullet_8);
			LONNIJMNKFB().SetFloat("LevelNameInputField", Bullet_9);
			MFHPKGICPIO().SetFloat("resetall", Bullet_10);
			DKNJGHFLAIF().SetFloat("#onfirstranktext", Bullet_11);
			DKNJGHFLAIF().SetFloat("st", Bullet_12);
			DBOLLHHMKKN().SetTexture("Crosshair2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1099f)
			{
				HBJJOCHGOPH = 1991f;
			}
			DKNJGHFLAIF().SetFloat("[SERVER] Player ", HBJJOCHGOPH);
			if (Bullet_1 < 394f)
			{
				Bullet_1 = 1095f;
			}
			if (Bullet_2 < 1289f)
			{
				Bullet_2 = 1148f;
			}
			if (Bullet_3 < 716f)
			{
				Bullet_3 = 1013f;
			}
			if (Bullet_4 < 1759f)
			{
				Bullet_4 = 621f;
			}
			if (Bullet_5 < 535f)
			{
				Bullet_5 = 142f;
			}
			if (Bullet_6 < 1938f)
			{
				Bullet_6 = 968f;
			}
			if (Bullet_7 < 419f)
			{
				Bullet_7 = 1364f;
			}
			if (Bullet_8 < 764f)
			{
				Bullet_8 = 1027f;
			}
			if (Bullet_9 < 1966f)
			{
				Bullet_9 = 458f;
			}
			if (Bullet_10 < 1553f)
			{
				Bullet_10 = 841f;
			}
			if (Bullet_11 < 847f)
			{
				Bullet_11 = 454f;
			}
			if (Bullet_12 < 1105f)
			{
				Bullet_12 = 1807f;
			}
			if (Bullet_1 > 1116f)
			{
				Bullet_1 = 1613f;
			}
			if (Bullet_2 > 1707f)
			{
				Bullet_2 = 1716f;
			}
			if (Bullet_3 > 405f)
			{
				Bullet_3 = 564f;
			}
			if (Bullet_4 > 486f)
			{
				Bullet_4 = 1897f;
			}
			if (Bullet_5 > 641f)
			{
				Bullet_5 = 127f;
			}
			if (Bullet_6 > 808f)
			{
				Bullet_6 = 897f;
			}
			if (Bullet_7 > 574f)
			{
				Bullet_7 = 1143f;
			}
			if (Bullet_8 > 1707f)
			{
				Bullet_8 = 603f;
			}
			if (Bullet_9 > 816f)
			{
				Bullet_9 = 1977f;
			}
			if (Bullet_10 > 361f)
			{
				Bullet_10 = 1712f;
			}
			if (Bullet_11 > 1860f)
			{
				Bullet_11 = 1511f;
			}
			if (Bullet_12 > 1704f)
			{
				Bullet_12 = 1578f;
			}
			NDMPCDHADMJ().SetFloat("_TimeX", Bullet_1);
			MFHPKGICPIO().SetFloat("_TimeX", Bullet_2);
			NBPKMLMCHFN.SetFloat("_Value1", Bullet_3);
			ADBKPGFMNKO().SetFloat("Hex value #RRGGBB", Bullet_4);
			IIBLJCKLGFG().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Bullet_5);
			NBPKMLMCHFN.SetFloat("Set Particles Color", Bullet_6);
			LONNIJMNKFB().SetFloat("[PlayerController] ", Bullet_7);
			OCHJIMJNEMO().SetFloat("_Colorisation", Bullet_8);
			NDMPCDHADMJ().SetFloat("_Blue_C", Bullet_9);
			IIBLJCKLGFG().SetFloat(".lastCheckpoint.time", Bullet_10);
			OCHJIMJNEMO().SetFloat("_Value3", Bullet_11);
			OCHJIMJNEMO().SetFloat("NEW_ACHIEVEMENT_1_26", Bullet_12);
			MFHPKGICPIO().SetTexture("_Line", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 439f)
			{
				HBJJOCHGOPH = 1449f;
			}
			DBOLLHHMKKN().SetFloat("Hello", HBJJOCHGOPH);
			if (Bullet_1 < 1082f)
			{
				Bullet_1 = 950f;
			}
			if (Bullet_2 < 1494f)
			{
				Bullet_2 = 1570f;
			}
			if (Bullet_3 < 1395f)
			{
				Bullet_3 = 1983f;
			}
			if (Bullet_4 < 877f)
			{
				Bullet_4 = 343f;
			}
			if (Bullet_5 < 325f)
			{
				Bullet_5 = 1096f;
			}
			if (Bullet_6 < 835f)
			{
				Bullet_6 = 115f;
			}
			if (Bullet_7 < 1638f)
			{
				Bullet_7 = 1206f;
			}
			if (Bullet_8 < 642f)
			{
				Bullet_8 = 1288f;
			}
			if (Bullet_9 < 1303f)
			{
				Bullet_9 = 1314f;
			}
			if (Bullet_10 < 1822f)
			{
				Bullet_10 = 11f;
			}
			if (Bullet_11 < 365f)
			{
				Bullet_11 = 1095f;
			}
			if (Bullet_12 < 251f)
			{
				Bullet_12 = 1597f;
			}
			if (Bullet_1 > 1776f)
			{
				Bullet_1 = 219f;
			}
			if (Bullet_2 > 167f)
			{
				Bullet_2 = 1874f;
			}
			if (Bullet_3 > 784f)
			{
				Bullet_3 = 1370f;
			}
			if (Bullet_4 > 1585f)
			{
				Bullet_4 = 1802f;
			}
			if (Bullet_5 > 597f)
			{
				Bullet_5 = 1836f;
			}
			if (Bullet_6 > 872f)
			{
				Bullet_6 = 48f;
			}
			if (Bullet_7 > 649f)
			{
				Bullet_7 = 923f;
			}
			if (Bullet_8 > 27f)
			{
				Bullet_8 = 171f;
			}
			if (Bullet_9 > 211f)
			{
				Bullet_9 = 1980f;
			}
			if (Bullet_10 > 590f)
			{
				Bullet_10 = 1288f;
			}
			if (Bullet_11 > 860f)
			{
				Bullet_11 = 1114f;
			}
			if (Bullet_12 > 1271f)
			{
				Bullet_12 = 1313f;
			}
			LONNIJMNKFB().SetFloat("_ScreenResolution", Bullet_1);
			OCHJIMJNEMO().SetFloat("Image", Bullet_2);
			IIBLJCKLGFG().SetFloat(".lastCheckpoint.bgcolor", Bullet_3);
			LONNIJMNKFB().SetFloat("%", Bullet_4);
			HCGJCMDJPGD().SetFloat("/music", Bullet_5);
			ADBKPGFMNKO().SetFloat("_HexaColor", Bullet_6);
			DKNJGHFLAIF().SetFloat("settings.fps", Bullet_7);
			IIBLJCKLGFG().SetFloat("error", Bullet_8);
			NDMPCDHADMJ().SetFloat("_Glitch", Bullet_9);
			ADBKPGFMNKO().SetFloat("Editor/", Bullet_10);
			DKNJGHFLAIF().SetFloat("_BlurVector", Bullet_11);
			IIBLJCKLGFG().SetFloat("[Up-Right-Down]", Bullet_12);
			NDMPCDHADMJ().SetTexture("{0:0} minute{1}, ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 617f)
			{
				HBJJOCHGOPH = 665f;
			}
			NBPKMLMCHFN.SetFloat("SetPosition", HBJJOCHGOPH);
			if (Bullet_1 < 97f)
			{
				Bullet_1 = 341f;
			}
			if (Bullet_2 < 1226f)
			{
				Bullet_2 = 802f;
			}
			if (Bullet_3 < 1796f)
			{
				Bullet_3 = 387f;
			}
			if (Bullet_4 < 230f)
			{
				Bullet_4 = 832f;
			}
			if (Bullet_5 < 1062f)
			{
				Bullet_5 = 709f;
			}
			if (Bullet_6 < 1609f)
			{
				Bullet_6 = 327f;
			}
			if (Bullet_7 < 1847f)
			{
				Bullet_7 = 424f;
			}
			if (Bullet_8 < 535f)
			{
				Bullet_8 = 1318f;
			}
			if (Bullet_9 < 1382f)
			{
				Bullet_9 = 1161f;
			}
			if (Bullet_10 < 735f)
			{
				Bullet_10 = 1701f;
			}
			if (Bullet_11 < 458f)
			{
				Bullet_11 = 1001f;
			}
			if (Bullet_12 < 1209f)
			{
				Bullet_12 = 748f;
			}
			if (Bullet_1 > 965f)
			{
				Bullet_1 = 1332f;
			}
			if (Bullet_2 > 1388f)
			{
				Bullet_2 = 1440f;
			}
			if (Bullet_3 > 547f)
			{
				Bullet_3 = 377f;
			}
			if (Bullet_4 > 852f)
			{
				Bullet_4 = 591f;
			}
			if (Bullet_5 > 253f)
			{
				Bullet_5 = 633f;
			}
			if (Bullet_6 > 1534f)
			{
				Bullet_6 = 822f;
			}
			if (Bullet_7 > 1283f)
			{
				Bullet_7 = 1031f;
			}
			if (Bullet_8 > 1490f)
			{
				Bullet_8 = 273f;
			}
			if (Bullet_9 > 990f)
			{
				Bullet_9 = 70f;
			}
			if (Bullet_10 > 1332f)
			{
				Bullet_10 = 1194f;
			}
			if (Bullet_11 > 383f)
			{
				Bullet_11 = 494f;
			}
			if (Bullet_12 > 401f)
			{
				Bullet_12 = 1308f;
			}
			OCHJIMJNEMO().SetFloat("StopSounds", Bullet_1);
			NBPKMLMCHFN.SetFloat("PunPickupSimple", Bullet_2);
			IIBLJCKLGFG().SetFloat("SupportLogger Info: PUN {0}: ", Bullet_3);
			OCHJIMJNEMO().SetFloat("mapselector.filter.favoriteonly", Bullet_4);
			DBOLLHHMKKN().SetFloat("_Value13", Bullet_5);
			ADBKPGFMNKO().SetFloat("_TimeX", Bullet_6);
			MFHPKGICPIO().SetFloat("_TimeX", Bullet_7);
			NDMPCDHADMJ().SetFloat("LevelNameText", Bullet_8);
			LONNIJMNKFB().SetFloat("_Far", Bullet_9);
			DKNJGHFLAIF().SetFloat(" {0}", Bullet_10);
			DBOLLHHMKKN().SetFloat("player.currentrank", Bullet_11);
			HCGJCMDJPGD().SetFloat(" or player:", Bullet_12);
			HCGJCMDJPGD().SetTexture("#close", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load(":") as Texture2D;
		SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 677f)
			{
				HBJJOCHGOPH = 476f;
			}
			IIBLJCKLGFG().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			if (Bullet_1 < 62f)
			{
				Bullet_1 = 1840f;
			}
			if (Bullet_2 < 1992f)
			{
				Bullet_2 = 1121f;
			}
			if (Bullet_3 < 1037f)
			{
				Bullet_3 = 1695f;
			}
			if (Bullet_4 < 765f)
			{
				Bullet_4 = 1886f;
			}
			if (Bullet_5 < 805f)
			{
				Bullet_5 = 534f;
			}
			if (Bullet_6 < 1172f)
			{
				Bullet_6 = 1615f;
			}
			if (Bullet_7 < 117f)
			{
				Bullet_7 = 307f;
			}
			if (Bullet_8 < 1346f)
			{
				Bullet_8 = 1460f;
			}
			if (Bullet_9 < 460f)
			{
				Bullet_9 = 76f;
			}
			if (Bullet_10 < 494f)
			{
				Bullet_10 = 1897f;
			}
			if (Bullet_11 < 1728f)
			{
				Bullet_11 = 1252f;
			}
			if (Bullet_12 < 1172f)
			{
				Bullet_12 = 1291f;
			}
			if (Bullet_1 > 1449f)
			{
				Bullet_1 = 1199f;
			}
			if (Bullet_2 > 358f)
			{
				Bullet_2 = 429f;
			}
			if (Bullet_3 > 828f)
			{
				Bullet_3 = 388f;
			}
			if (Bullet_4 > 582f)
			{
				Bullet_4 = 1972f;
			}
			if (Bullet_5 > 1116f)
			{
				Bullet_5 = 253f;
			}
			if (Bullet_6 > 1496f)
			{
				Bullet_6 = 1567f;
			}
			if (Bullet_7 > 535f)
			{
				Bullet_7 = 56f;
			}
			if (Bullet_8 > 342f)
			{
				Bullet_8 = 966f;
			}
			if (Bullet_9 > 1841f)
			{
				Bullet_9 = 1946f;
			}
			if (Bullet_10 > 1054f)
			{
				Bullet_10 = 595f;
			}
			if (Bullet_11 > 35f)
			{
				Bullet_11 = 1616f;
			}
			if (Bullet_12 > 625f)
			{
				Bullet_12 = 1147f;
			}
			LONNIJMNKFB().SetFloat("turn", Bullet_1);
			HCGJCMDJPGD().SetFloat("ConfigVersionSlider", Bullet_2);
			OCHJIMJNEMO().SetFloat("CameraFilterPack/Blend2Camera_Divide", Bullet_3);
			OCHJIMJNEMO().SetFloat("CameraFilterPack/TV_Chromatical", Bullet_4);
			NDMPCDHADMJ().SetFloat("RecordButton", Bullet_5);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Atmosphere_Fog", Bullet_6);
			ADBKPGFMNKO().SetFloat("st", Bullet_7);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Atmosphere_Rain", Bullet_8);
			LONNIJMNKFB().SetFloat("_BlurRadius", Bullet_9);
			HCGJCMDJPGD().SetFloat("updating", Bullet_10);
			ADBKPGFMNKO().SetFloat("Tab1Content", Bullet_11);
			IIBLJCKLGFG().SetFloat("[ItemsHandler] Item not found:", Bullet_12);
			HCGJCMDJPGD().SetTexture("settings.enablehitsoundsinnormal", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("settings.gamemessagesduration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DIPDEHOOBPG()
	{
		FPHEBLMINDA = Resources.Load("PointerEnter ") as Texture2D;
		SCShader = Shader.Find("player.gamecompleted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("t") as Texture2D;
		SCShader = Shader.Find(". Verify the Prefab is in a Resources folder (and not in a subfolder)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 516f)
			{
				HBJJOCHGOPH = 1229f;
			}
			IIBLJCKLGFG().SetFloat("[ItemsHandler] No connection to item server: ", HBJJOCHGOPH);
			if (Bullet_1 < 709f)
			{
				Bullet_1 = 1816f;
			}
			if (Bullet_2 < 1f)
			{
				Bullet_2 = 385f;
			}
			if (Bullet_3 < 177f)
			{
				Bullet_3 = 810f;
			}
			if (Bullet_4 < 1799f)
			{
				Bullet_4 = 222f;
			}
			if (Bullet_5 < 1889f)
			{
				Bullet_5 = 613f;
			}
			if (Bullet_6 < 13f)
			{
				Bullet_6 = 893f;
			}
			if (Bullet_7 < 7f)
			{
				Bullet_7 = 692f;
			}
			if (Bullet_8 < 1721f)
			{
				Bullet_8 = 922f;
			}
			if (Bullet_9 < 70f)
			{
				Bullet_9 = 1502f;
			}
			if (Bullet_10 < 1740f)
			{
				Bullet_10 = 1541f;
			}
			if (Bullet_11 < 1920f)
			{
				Bullet_11 = 1163f;
			}
			if (Bullet_12 < 1966f)
			{
				Bullet_12 = 1227f;
			}
			if (Bullet_1 > 497f)
			{
				Bullet_1 = 245f;
			}
			if (Bullet_2 > 1666f)
			{
				Bullet_2 = 439f;
			}
			if (Bullet_3 > 674f)
			{
				Bullet_3 = 220f;
			}
			if (Bullet_4 > 1433f)
			{
				Bullet_4 = 235f;
			}
			if (Bullet_5 > 760f)
			{
				Bullet_5 = 328f;
			}
			if (Bullet_6 > 757f)
			{
				Bullet_6 = 1067f;
			}
			if (Bullet_7 > 1810f)
			{
				Bullet_7 = 1167f;
			}
			if (Bullet_8 > 681f)
			{
				Bullet_8 = 1540f;
			}
			if (Bullet_9 > 1878f)
			{
				Bullet_9 = 1646f;
			}
			if (Bullet_10 > 177f)
			{
				Bullet_10 = 449f;
			}
			if (Bullet_11 > 1871f)
			{
				Bullet_11 = 1580f;
			}
			if (Bullet_12 > 1021f)
			{
				Bullet_12 = 1253f;
			}
			LONNIJMNKFB().SetFloat("_ScreenResolution", Bullet_1);
			NBPKMLMCHFN.SetFloat("/", Bullet_2);
			NDMPCDHADMJ().SetFloat("_Value2", Bullet_3);
			DKNJGHFLAIF().SetFloat("_TintColor", Bullet_4);
			ADBKPGFMNKO().SetFloat("SpawnObj", Bullet_5);
			DKNJGHFLAIF().SetFloat("CloseConnection: Only the masterclient can kick another player.", Bullet_6);
			DKNJGHFLAIF().SetFloat("_MatrixSpeed", Bullet_7);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Bullet_8);
			OCHJIMJNEMO().SetFloat("PunRespawn", Bullet_9);
			NDMPCDHADMJ().SetFloat("Editor", Bullet_10);
			NDMPCDHADMJ().SetFloat("Tab1Content", Bullet_11);
			IIBLJCKLGFG().SetFloat("itemid", Bullet_12);
			DBOLLHHMKKN().SetTexture("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return BJFKDHHMLJH;
	}

	private void BGDONBMDPGM()
	{
	}

	private void JNBPKNNBMDI()
	{
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load("Loss ") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack_VHS2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("<b>(╯°□°）╯︵ ┻━┻</b>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 854f)
			{
				HBJJOCHGOPH = 1525f;
			}
			IIBLJCKLGFG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			if (Bullet_1 < 345f)
			{
				Bullet_1 = 1527f;
			}
			if (Bullet_2 < 16f)
			{
				Bullet_2 = 1990f;
			}
			if (Bullet_3 < 865f)
			{
				Bullet_3 = 964f;
			}
			if (Bullet_4 < 481f)
			{
				Bullet_4 = 1209f;
			}
			if (Bullet_5 < 1440f)
			{
				Bullet_5 = 172f;
			}
			if (Bullet_6 < 288f)
			{
				Bullet_6 = 496f;
			}
			if (Bullet_7 < 1866f)
			{
				Bullet_7 = 509f;
			}
			if (Bullet_8 < 1176f)
			{
				Bullet_8 = 1438f;
			}
			if (Bullet_9 < 36f)
			{
				Bullet_9 = 1631f;
			}
			if (Bullet_10 < 1486f)
			{
				Bullet_10 = 444f;
			}
			if (Bullet_11 < 951f)
			{
				Bullet_11 = 17f;
			}
			if (Bullet_12 < 523f)
			{
				Bullet_12 = 299f;
			}
			if (Bullet_1 > 577f)
			{
				Bullet_1 = 500f;
			}
			if (Bullet_2 > 155f)
			{
				Bullet_2 = 221f;
			}
			if (Bullet_3 > 1115f)
			{
				Bullet_3 = 1625f;
			}
			if (Bullet_4 > 806f)
			{
				Bullet_4 = 1651f;
			}
			if (Bullet_5 > 1674f)
			{
				Bullet_5 = 1099f;
			}
			if (Bullet_6 > 1024f)
			{
				Bullet_6 = 1952f;
			}
			if (Bullet_7 > 992f)
			{
				Bullet_7 = 1020f;
			}
			if (Bullet_8 > 1979f)
			{
				Bullet_8 = 216f;
			}
			if (Bullet_9 > 42f)
			{
				Bullet_9 = 1677f;
			}
			if (Bullet_10 > 1792f)
			{
				Bullet_10 = 1908f;
			}
			if (Bullet_11 > 706f)
			{
				Bullet_11 = 680f;
			}
			if (Bullet_12 > 823f)
			{
				Bullet_12 = 1034f;
			}
			ADBKPGFMNKO().SetFloat("z", Bullet_1);
			NBPKMLMCHFN.SetFloat("{}", Bullet_2);
			IIBLJCKLGFG().SetFloat("EventSystem", Bullet_3);
			IIBLJCKLGFG().SetFloat("DPADHOR", Bullet_4);
			DKNJGHFLAIF().SetFloat("\r", Bullet_5);
			LONNIJMNKFB().SetFloat("/icon", Bullet_6);
			OCHJIMJNEMO().SetFloat("file://", Bullet_7);
			NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Bullet_8);
			MFHPKGICPIO().SetFloat("[LevelEditorScene] Error: Timeout :S", Bullet_9);
			DKNJGHFLAIF().SetFloat("OpJoinRoom()", Bullet_10);
			MFHPKGICPIO().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", Bullet_11);
			IIBLJCKLGFG().SetFloat("z", Bullet_12);
			NDMPCDHADMJ().SetTexture("menu.selectedplaymode", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("ScreenResolutionPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find(" has ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1455f)
			{
				HBJJOCHGOPH = 1406f;
			}
			NDMPCDHADMJ().SetFloat("VisionBlur", HBJJOCHGOPH);
			if (Bullet_1 < 528f)
			{
				Bullet_1 = 612f;
			}
			if (Bullet_2 < 1980f)
			{
				Bullet_2 = 989f;
			}
			if (Bullet_3 < 1659f)
			{
				Bullet_3 = 892f;
			}
			if (Bullet_4 < 1083f)
			{
				Bullet_4 = 1003f;
			}
			if (Bullet_5 < 1504f)
			{
				Bullet_5 = 1932f;
			}
			if (Bullet_6 < 772f)
			{
				Bullet_6 = 1817f;
			}
			if (Bullet_7 < 343f)
			{
				Bullet_7 = 868f;
			}
			if (Bullet_8 < 373f)
			{
				Bullet_8 = 500f;
			}
			if (Bullet_9 < 1181f)
			{
				Bullet_9 = 1557f;
			}
			if (Bullet_10 < 1418f)
			{
				Bullet_10 = 877f;
			}
			if (Bullet_11 < 423f)
			{
				Bullet_11 = 183f;
			}
			if (Bullet_12 < 1181f)
			{
				Bullet_12 = 1738f;
			}
			if (Bullet_1 > 1960f)
			{
				Bullet_1 = 1553f;
			}
			if (Bullet_2 > 1989f)
			{
				Bullet_2 = 1368f;
			}
			if (Bullet_3 > 259f)
			{
				Bullet_3 = 705f;
			}
			if (Bullet_4 > 1167f)
			{
				Bullet_4 = 466f;
			}
			if (Bullet_5 > 944f)
			{
				Bullet_5 = 1156f;
			}
			if (Bullet_6 > 138f)
			{
				Bullet_6 = 628f;
			}
			if (Bullet_7 > 1659f)
			{
				Bullet_7 = 625f;
			}
			if (Bullet_8 > 352f)
			{
				Bullet_8 = 562f;
			}
			if (Bullet_9 > 1161f)
			{
				Bullet_9 = 811f;
			}
			if (Bullet_10 > 1999f)
			{
				Bullet_10 = 483f;
			}
			if (Bullet_11 > 465f)
			{
				Bullet_11 = 1910f;
			}
			if (Bullet_12 > 551f)
			{
				Bullet_12 = 33f;
			}
			NDMPCDHADMJ().SetFloat("HiddenToggle", Bullet_1);
			IIBLJCKLGFG().SetFloat("color", Bullet_2);
			IIBLJCKLGFG().SetFloat("http", Bullet_3);
			ADBKPGFMNKO().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Bullet_4);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.perfectHits", Bullet_5);
			DKNJGHFLAIF().SetFloat("_Intensity", Bullet_6);
			NBPKMLMCHFN.SetFloat("win", Bullet_7);
			NBPKMLMCHFN.SetFloat("_Value2", Bullet_8);
			NBPKMLMCHFN.SetFloat("#savemapchanges?", Bullet_9);
			OCHJIMJNEMO().SetFloat("_ScreenEdgeFading", Bullet_10);
			OCHJIMJNEMO().SetFloat(" ", Bullet_11);
			NBPKMLMCHFN.SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", Bullet_12);
			DKNJGHFLAIF().SetTexture("[PlayerController] ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return BJFKDHHMLJH;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1217f)
			{
				HBJJOCHGOPH = 1483f;
			}
			NDMPCDHADMJ().SetFloat("0.00", HBJJOCHGOPH);
			if (Bullet_1 < 1041f)
			{
				Bullet_1 = 1423f;
			}
			if (Bullet_2 < 121f)
			{
				Bullet_2 = 1462f;
			}
			if (Bullet_3 < 418f)
			{
				Bullet_3 = 401f;
			}
			if (Bullet_4 < 199f)
			{
				Bullet_4 = 277f;
			}
			if (Bullet_5 < 1492f)
			{
				Bullet_5 = 1168f;
			}
			if (Bullet_6 < 760f)
			{
				Bullet_6 = 1407f;
			}
			if (Bullet_7 < 1535f)
			{
				Bullet_7 = 246f;
			}
			if (Bullet_8 < 197f)
			{
				Bullet_8 = 271f;
			}
			if (Bullet_9 < 1401f)
			{
				Bullet_9 = 1946f;
			}
			if (Bullet_10 < 552f)
			{
				Bullet_10 = 1663f;
			}
			if (Bullet_11 < 937f)
			{
				Bullet_11 = 243f;
			}
			if (Bullet_12 < 1746f)
			{
				Bullet_12 = 1620f;
			}
			if (Bullet_1 > 1087f)
			{
				Bullet_1 = 1188f;
			}
			if (Bullet_2 > 582f)
			{
				Bullet_2 = 494f;
			}
			if (Bullet_3 > 1383f)
			{
				Bullet_3 = 94f;
			}
			if (Bullet_4 > 414f)
			{
				Bullet_4 = 724f;
			}
			if (Bullet_5 > 761f)
			{
				Bullet_5 = 503f;
			}
			if (Bullet_6 > 1685f)
			{
				Bullet_6 = 880f;
			}
			if (Bullet_7 > 743f)
			{
				Bullet_7 = 376f;
			}
			if (Bullet_8 > 560f)
			{
				Bullet_8 = 1612f;
			}
			if (Bullet_9 > 1245f)
			{
				Bullet_9 = 1291f;
			}
			if (Bullet_10 > 703f)
			{
				Bullet_10 = 540f;
			}
			if (Bullet_11 > 715f)
			{
				Bullet_11 = 1101f;
			}
			if (Bullet_12 > 676f)
			{
				Bullet_12 = 830f;
			}
			MFHPKGICPIO().SetFloat("LevelInfoInputField", Bullet_1);
			OCHJIMJNEMO().SetFloat(" not exist", Bullet_2);
			ADBKPGFMNKO().SetFloat("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", Bullet_3);
			IIBLJCKLGFG().SetFloat("_Value3", Bullet_4);
			MFHPKGICPIO().SetFloat("PublishButton", Bullet_5);
			OCHJIMJNEMO().SetFloat("input", Bullet_6);
			DKNJGHFLAIF().SetFloat("maps.", Bullet_7);
			NBPKMLMCHFN.SetFloat("_TimeX", Bullet_8);
			IIBLJCKLGFG().SetFloat("settings_bindings_", Bullet_9);
			ADBKPGFMNKO().SetFloat("SpawnObj", Bullet_10);
			NDMPCDHADMJ().SetFloat("path", Bullet_11);
			IIBLJCKLGFG().SetFloat("source", Bullet_12);
			IIBLJCKLGFG().SetTexture("Data/Editor/leveltemplate", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 749f)
			{
				HBJJOCHGOPH = 1967f;
			}
			OCHJIMJNEMO().SetFloat("scenes", HBJJOCHGOPH);
			if (Bullet_1 < 1202f)
			{
				Bullet_1 = 1467f;
			}
			if (Bullet_2 < 134f)
			{
				Bullet_2 = 365f;
			}
			if (Bullet_3 < 1616f)
			{
				Bullet_3 = 1301f;
			}
			if (Bullet_4 < 675f)
			{
				Bullet_4 = 1519f;
			}
			if (Bullet_5 < 1907f)
			{
				Bullet_5 = 917f;
			}
			if (Bullet_6 < 982f)
			{
				Bullet_6 = 857f;
			}
			if (Bullet_7 < 903f)
			{
				Bullet_7 = 1985f;
			}
			if (Bullet_8 < 221f)
			{
				Bullet_8 = 1570f;
			}
			if (Bullet_9 < 1971f)
			{
				Bullet_9 = 913f;
			}
			if (Bullet_10 < 271f)
			{
				Bullet_10 = 1559f;
			}
			if (Bullet_11 < 1896f)
			{
				Bullet_11 = 582f;
			}
			if (Bullet_12 < 7f)
			{
				Bullet_12 = 267f;
			}
			if (Bullet_1 > 1093f)
			{
				Bullet_1 = 166f;
			}
			if (Bullet_2 > 924f)
			{
				Bullet_2 = 374f;
			}
			if (Bullet_3 > 883f)
			{
				Bullet_3 = 973f;
			}
			if (Bullet_4 > 72f)
			{
				Bullet_4 = 730f;
			}
			if (Bullet_5 > 1837f)
			{
				Bullet_5 = 1352f;
			}
			if (Bullet_6 > 1929f)
			{
				Bullet_6 = 1701f;
			}
			if (Bullet_7 > 747f)
			{
				Bullet_7 = 1967f;
			}
			if (Bullet_8 > 1553f)
			{
				Bullet_8 = 1097f;
			}
			if (Bullet_9 > 1532f)
			{
				Bullet_9 = 1510f;
			}
			if (Bullet_10 > 708f)
			{
				Bullet_10 = 997f;
			}
			if (Bullet_11 > 864f)
			{
				Bullet_11 = 1122f;
			}
			if (Bullet_12 > 1578f)
			{
				Bullet_12 = 245f;
			}
			DBOLLHHMKKN().SetFloat("_Fade", Bullet_1);
			DKNJGHFLAIF().SetFloat("/Segment-[Down]", Bullet_2);
			ADBKPGFMNKO().SetFloat("_NumberOfWaves", Bullet_3);
			NDMPCDHADMJ().SetFloat("_Saturation", Bullet_4);
			MFHPKGICPIO().SetFloat("[Down]", Bullet_5);
			HCGJCMDJPGD().SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Bullet_6);
			ADBKPGFMNKO().SetFloat("_ScreenResolution", Bullet_7);
			NBPKMLMCHFN.SetFloat("_Value2", Bullet_8);
			OCHJIMJNEMO().SetFloat("EnvironmentSlider", Bullet_9);
			NBPKMLMCHFN.SetFloat("_NoiseTex", Bullet_10);
			DKNJGHFLAIF().SetFloat("_TimeX", Bullet_11);
			NBPKMLMCHFN.SetFloat("ViewMenu", Bullet_12);
			IIBLJCKLGFG().SetTexture("_Value4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMCPMOGKDEH()
	{
		FPHEBLMINDA = Resources.Load("_Value10") as Texture2D;
		SCShader = Shader.Find(".g");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void POIMNOBDBBN()
	{
	}

	private void LIBGAKMKHJJ()
	{
		FPHEBLMINDA = Resources.Load(">") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/FX_EarthQuake");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 414f)
			{
				HBJJOCHGOPH = 1558f;
			}
			HCGJCMDJPGD().SetFloat("no lives color", HBJJOCHGOPH);
			if (Bullet_1 < 1734f)
			{
				Bullet_1 = 494f;
			}
			if (Bullet_2 < 1738f)
			{
				Bullet_2 = 1413f;
			}
			if (Bullet_3 < 751f)
			{
				Bullet_3 = 1998f;
			}
			if (Bullet_4 < 1310f)
			{
				Bullet_4 = 1258f;
			}
			if (Bullet_5 < 1481f)
			{
				Bullet_5 = 1383f;
			}
			if (Bullet_6 < 1109f)
			{
				Bullet_6 = 1783f;
			}
			if (Bullet_7 < 1480f)
			{
				Bullet_7 = 41f;
			}
			if (Bullet_8 < 142f)
			{
				Bullet_8 = 990f;
			}
			if (Bullet_9 < 1265f)
			{
				Bullet_9 = 969f;
			}
			if (Bullet_10 < 1807f)
			{
				Bullet_10 = 1886f;
			}
			if (Bullet_11 < 525f)
			{
				Bullet_11 = 1811f;
			}
			if (Bullet_12 < 1585f)
			{
				Bullet_12 = 497f;
			}
			if (Bullet_1 > 356f)
			{
				Bullet_1 = 442f;
			}
			if (Bullet_2 > 1681f)
			{
				Bullet_2 = 35f;
			}
			if (Bullet_3 > 1393f)
			{
				Bullet_3 = 241f;
			}
			if (Bullet_4 > 997f)
			{
				Bullet_4 = 774f;
			}
			if (Bullet_5 > 315f)
			{
				Bullet_5 = 1615f;
			}
			if (Bullet_6 > 1629f)
			{
				Bullet_6 = 1072f;
			}
			if (Bullet_7 > 820f)
			{
				Bullet_7 = 116f;
			}
			if (Bullet_8 > 112f)
			{
				Bullet_8 = 161f;
			}
			if (Bullet_9 > 1701f)
			{
				Bullet_9 = 1973f;
			}
			if (Bullet_10 > 105f)
			{
				Bullet_10 = 1067f;
			}
			if (Bullet_11 > 839f)
			{
				Bullet_11 = 1206f;
			}
			if (Bullet_12 > 1723f)
			{
				Bullet_12 = 1260f;
			}
			IIBLJCKLGFG().SetFloat("achievements.21.progress", Bullet_1);
			DKNJGHFLAIF().SetFloat("Map id for", Bullet_2);
			ADBKPGFMNKO().SetFloat("_Distortion", Bullet_3);
			DKNJGHFLAIF().SetFloat("Hidden/TonemappingColorGrading", Bullet_4);
			MFHPKGICPIO().SetFloat("Health Stats", Bullet_5);
			NBPKMLMCHFN.SetFloat("#ok", Bullet_6);
			OCHJIMJNEMO().SetFloat("UseScanLineSize", Bullet_7);
			NDMPCDHADMJ().SetFloat(", our prefix is ", Bullet_8);
			MFHPKGICPIO().SetFloat("_ScreenResolution", Bullet_9);
			LONNIJMNKFB().SetFloat("_TimeX", Bullet_10);
			IIBLJCKLGFG().SetFloat("Gameplay/Base", Bullet_11);
			DBOLLHHMKKN().SetFloat("DifficultyBG", Bullet_12);
			NDMPCDHADMJ().SetTexture("Gameplay/sun", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("settings.customdataskin") as Texture2D;
		SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			if (Bullet_1 < 0f)
			{
				Bullet_1 = 0f;
			}
			if (Bullet_2 < 0f)
			{
				Bullet_2 = 0f;
			}
			if (Bullet_3 < 0f)
			{
				Bullet_3 = 0f;
			}
			if (Bullet_4 < 0f)
			{
				Bullet_4 = 0f;
			}
			if (Bullet_5 < 0f)
			{
				Bullet_5 = 0f;
			}
			if (Bullet_6 < 0f)
			{
				Bullet_6 = 0f;
			}
			if (Bullet_7 < 0f)
			{
				Bullet_7 = 0f;
			}
			if (Bullet_8 < 0f)
			{
				Bullet_8 = 0f;
			}
			if (Bullet_9 < 0f)
			{
				Bullet_9 = 0f;
			}
			if (Bullet_10 < 0f)
			{
				Bullet_10 = 0f;
			}
			if (Bullet_11 < 0f)
			{
				Bullet_11 = 0f;
			}
			if (Bullet_12 < 0f)
			{
				Bullet_12 = 0f;
			}
			if (Bullet_1 > 1f)
			{
				Bullet_1 = 1f;
			}
			if (Bullet_2 > 1f)
			{
				Bullet_2 = 1f;
			}
			if (Bullet_3 > 1f)
			{
				Bullet_3 = 1f;
			}
			if (Bullet_4 > 1f)
			{
				Bullet_4 = 1f;
			}
			if (Bullet_5 > 1f)
			{
				Bullet_5 = 1f;
			}
			if (Bullet_6 > 1f)
			{
				Bullet_6 = 1f;
			}
			if (Bullet_7 > 1f)
			{
				Bullet_7 = 1f;
			}
			if (Bullet_8 > 1f)
			{
				Bullet_8 = 1f;
			}
			if (Bullet_9 > 1f)
			{
				Bullet_9 = 1f;
			}
			if (Bullet_10 > 1f)
			{
				Bullet_10 = 1f;
			}
			if (Bullet_11 > 1f)
			{
				Bullet_11 = 1f;
			}
			if (Bullet_12 > 1f)
			{
				Bullet_12 = 1f;
			}
			NBPKMLMCHFN.SetFloat("_Bullet_1", Bullet_1);
			NBPKMLMCHFN.SetFloat("_Bullet_2", Bullet_2);
			NBPKMLMCHFN.SetFloat("_Bullet_3", Bullet_3);
			NBPKMLMCHFN.SetFloat("_Bullet_4", Bullet_4);
			NBPKMLMCHFN.SetFloat("_Bullet_5", Bullet_5);
			NBPKMLMCHFN.SetFloat("_Bullet_6", Bullet_6);
			NBPKMLMCHFN.SetFloat("_Bullet_7", Bullet_7);
			NBPKMLMCHFN.SetFloat("_Bullet_8", Bullet_8);
			NBPKMLMCHFN.SetFloat("_Bullet_9", Bullet_9);
			NBPKMLMCHFN.SetFloat("_Bullet_10", Bullet_10);
			NBPKMLMCHFN.SetFloat("_Bullet_11", Bullet_11);
			NBPKMLMCHFN.SetFloat("_Bullet_12", Bullet_12);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		FPHEBLMINDA = Resources.Load("ConfigVersionSlider") as Texture2D;
		SCShader = Shader.Find("A");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Color_YUV") as Texture2D;
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void CGDMLHLJIDK()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("_Red_B") as Texture2D;
		SCShader = Shader.Find("TransferOwnership() view ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("true") as Texture2D;
		SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("Status: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("Value") as Texture2D;
		SCShader = Shader.Find("_VignetteDesat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("[MapsData] Unsubscribe ") as Texture2D;
		SCShader = Shader.Find("_PColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button7") as Texture2D;
		SCShader = Shader.Find("OnStatusChanged: {0} current State: {1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1625f)
			{
				HBJJOCHGOPH = 1863f;
			}
			NDMPCDHADMJ().SetFloat("_ChangeBlue", HBJJOCHGOPH);
			if (Bullet_1 < 1262f)
			{
				Bullet_1 = 434f;
			}
			if (Bullet_2 < 1905f)
			{
				Bullet_2 = 1685f;
			}
			if (Bullet_3 < 1201f)
			{
				Bullet_3 = 618f;
			}
			if (Bullet_4 < 1115f)
			{
				Bullet_4 = 901f;
			}
			if (Bullet_5 < 425f)
			{
				Bullet_5 = 799f;
			}
			if (Bullet_6 < 1445f)
			{
				Bullet_6 = 1357f;
			}
			if (Bullet_7 < 30f)
			{
				Bullet_7 = 112f;
			}
			if (Bullet_8 < 862f)
			{
				Bullet_8 = 485f;
			}
			if (Bullet_9 < 543f)
			{
				Bullet_9 = 559f;
			}
			if (Bullet_10 < 973f)
			{
				Bullet_10 = 1921f;
			}
			if (Bullet_11 < 1762f)
			{
				Bullet_11 = 781f;
			}
			if (Bullet_12 < 1790f)
			{
				Bullet_12 = 220f;
			}
			if (Bullet_1 > 347f)
			{
				Bullet_1 = 1129f;
			}
			if (Bullet_2 > 1576f)
			{
				Bullet_2 = 1232f;
			}
			if (Bullet_3 > 836f)
			{
				Bullet_3 = 1195f;
			}
			if (Bullet_4 > 1164f)
			{
				Bullet_4 = 609f;
			}
			if (Bullet_5 > 70f)
			{
				Bullet_5 = 216f;
			}
			if (Bullet_6 > 1258f)
			{
				Bullet_6 = 899f;
			}
			if (Bullet_7 > 595f)
			{
				Bullet_7 = 1566f;
			}
			if (Bullet_8 > 408f)
			{
				Bullet_8 = 662f;
			}
			if (Bullet_9 > 1930f)
			{
				Bullet_9 = 1648f;
			}
			if (Bullet_10 > 918f)
			{
				Bullet_10 = 1511f;
			}
			if (Bullet_11 > 1039f)
			{
				Bullet_11 = 351f;
			}
			if (Bullet_12 > 1551f)
			{
				Bullet_12 = 1865f;
			}
			LONNIJMNKFB().SetFloat("_SizeY", Bullet_1);
			OCHJIMJNEMO().SetFloat("[PowerUp]", Bullet_2);
			MFHPKGICPIO().SetFloat("Edited event", Bullet_3);
			OCHJIMJNEMO().SetFloat("LevelConfigButton", Bullet_4);
			IIBLJCKLGFG().SetFloat("_MainTex", Bullet_5);
			DBOLLHHMKKN().SetFloat("Command not found!", Bullet_6);
			MFHPKGICPIO().SetFloat("FinishMap", Bullet_7);
			DBOLLHHMKKN().SetFloat("Left Stick Click", Bullet_8);
			ADBKPGFMNKO().SetFloat("_TimeX", Bullet_9);
			ADBKPGFMNKO().SetFloat("mapselector.orderby", Bullet_10);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Lut_Simple", Bullet_11);
			ADBKPGFMNKO().SetFloat("_Value2", Bullet_12);
			NDMPCDHADMJ().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1146f)
			{
				HBJJOCHGOPH = 1320f;
			}
			LONNIJMNKFB().SetFloat("settings.selectormapsperpage", HBJJOCHGOPH);
			if (Bullet_1 < 1136f)
			{
				Bullet_1 = 1678f;
			}
			if (Bullet_2 < 412f)
			{
				Bullet_2 = 1202f;
			}
			if (Bullet_3 < 936f)
			{
				Bullet_3 = 1267f;
			}
			if (Bullet_4 < 5f)
			{
				Bullet_4 = 383f;
			}
			if (Bullet_5 < 302f)
			{
				Bullet_5 = 1376f;
			}
			if (Bullet_6 < 1693f)
			{
				Bullet_6 = 791f;
			}
			if (Bullet_7 < 268f)
			{
				Bullet_7 = 110f;
			}
			if (Bullet_8 < 1396f)
			{
				Bullet_8 = 262f;
			}
			if (Bullet_9 < 1558f)
			{
				Bullet_9 = 251f;
			}
			if (Bullet_10 < 1715f)
			{
				Bullet_10 = 1063f;
			}
			if (Bullet_11 < 1802f)
			{
				Bullet_11 = 1628f;
			}
			if (Bullet_12 < 995f)
			{
				Bullet_12 = 1932f;
			}
			if (Bullet_1 > 493f)
			{
				Bullet_1 = 1394f;
			}
			if (Bullet_2 > 408f)
			{
				Bullet_2 = 913f;
			}
			if (Bullet_3 > 1175f)
			{
				Bullet_3 = 894f;
			}
			if (Bullet_4 > 1696f)
			{
				Bullet_4 = 1589f;
			}
			if (Bullet_5 > 1803f)
			{
				Bullet_5 = 1690f;
			}
			if (Bullet_6 > 1145f)
			{
				Bullet_6 = 415f;
			}
			if (Bullet_7 > 1454f)
			{
				Bullet_7 = 1149f;
			}
			if (Bullet_8 > 1189f)
			{
				Bullet_8 = 1242f;
			}
			if (Bullet_9 > 951f)
			{
				Bullet_9 = 579f;
			}
			if (Bullet_10 > 1305f)
			{
				Bullet_10 = 252f;
			}
			if (Bullet_11 > 584f)
			{
				Bullet_11 = 1331f;
			}
			if (Bullet_12 > 1184f)
			{
				Bullet_12 = 190f;
			}
			DBOLLHHMKKN().SetFloat("note.5", Bullet_1);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Drawing_Laplacian", Bullet_2);
			NDMPCDHADMJ().SetFloat("offsets", Bullet_3);
			MFHPKGICPIO().SetFloat("_TimeX", Bullet_4);
			NDMPCDHADMJ().SetFloat("settings.enablehitsoundsinnormal", Bullet_5);
			ADBKPGFMNKO().SetFloat("The given 2D texture ", Bullet_6);
			DBOLLHHMKKN().SetFloat("GameScene", Bullet_7);
			NBPKMLMCHFN.SetFloat(".ogg", Bullet_8);
			HCGJCMDJPGD().SetFloat("HandsCountSlider", Bullet_9);
			NDMPCDHADMJ().SetFloat("_ThirdTex", Bullet_10);
			MFHPKGICPIO().SetFloat("_Visualize", Bullet_11);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", Bullet_12);
			IIBLJCKLGFG().SetTexture("CompletedLevel", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_BrokenGlass_2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("USE_UV_BASED_REPROJECTION") as Texture2D;
		SCShader = Shader.Find("true");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1668f)
			{
				HBJJOCHGOPH = 1032f;
			}
			DKNJGHFLAIF().SetFloat("_Offsets", HBJJOCHGOPH);
			if (Bullet_1 < 1243f)
			{
				Bullet_1 = 451f;
			}
			if (Bullet_2 < 1641f)
			{
				Bullet_2 = 1033f;
			}
			if (Bullet_3 < 884f)
			{
				Bullet_3 = 1611f;
			}
			if (Bullet_4 < 315f)
			{
				Bullet_4 = 559f;
			}
			if (Bullet_5 < 1798f)
			{
				Bullet_5 = 1692f;
			}
			if (Bullet_6 < 1767f)
			{
				Bullet_6 = 291f;
			}
			if (Bullet_7 < 736f)
			{
				Bullet_7 = 152f;
			}
			if (Bullet_8 < 1607f)
			{
				Bullet_8 = 299f;
			}
			if (Bullet_9 < 1468f)
			{
				Bullet_9 = 1512f;
			}
			if (Bullet_10 < 633f)
			{
				Bullet_10 = 351f;
			}
			if (Bullet_11 < 53f)
			{
				Bullet_11 = 1697f;
			}
			if (Bullet_12 < 434f)
			{
				Bullet_12 = 1405f;
			}
			if (Bullet_1 > 1160f)
			{
				Bullet_1 = 298f;
			}
			if (Bullet_2 > 1024f)
			{
				Bullet_2 = 1912f;
			}
			if (Bullet_3 > 1755f)
			{
				Bullet_3 = 78f;
			}
			if (Bullet_4 > 1391f)
			{
				Bullet_4 = 225f;
			}
			if (Bullet_5 > 1143f)
			{
				Bullet_5 = 1882f;
			}
			if (Bullet_6 > 91f)
			{
				Bullet_6 = 937f;
			}
			if (Bullet_7 > 1419f)
			{
				Bullet_7 = 1449f;
			}
			if (Bullet_8 > 145f)
			{
				Bullet_8 = 240f;
			}
			if (Bullet_9 > 308f)
			{
				Bullet_9 = 32f;
			}
			if (Bullet_10 > 1796f)
			{
				Bullet_10 = 998f;
			}
			if (Bullet_11 > 738f)
			{
				Bullet_11 = 856f;
			}
			if (Bullet_12 > 300f)
			{
				Bullet_12 = 157f;
			}
			NDMPCDHADMJ().SetFloat("_SpherePositionX", Bullet_1);
			IIBLJCKLGFG().SetFloat("DeleteButton", Bullet_2);
			HCGJCMDJPGD().SetFloat("Failed to 'network-remove' GameObject because it's null.", Bullet_3);
			IIBLJCKLGFG().SetFloat("Skipping EstablishEncryption. Protocol is secure.", Bullet_4);
			NBPKMLMCHFN.SetFloat("EditMenu", Bullet_5);
			NBPKMLMCHFN.SetFloat("SetupEncryption() got called. ", Bullet_6);
			DKNJGHFLAIF().SetFloat("distance", Bullet_7);
			OCHJIMJNEMO().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", Bullet_8);
			DBOLLHHMKKN().SetFloat("{0:0.0} ms ({1:0.} fps)", Bullet_9);
			OCHJIMJNEMO().SetFloat("???", Bullet_10);
			DBOLLHHMKKN().SetFloat("OnStatusChanged: {0} current State: {1}", Bullet_11);
			DKNJGHFLAIF().SetFloat("CrosshairOpacitySlider", Bullet_12);
			MFHPKGICPIO().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1312f)
			{
				HBJJOCHGOPH = 1008f;
			}
			ADBKPGFMNKO().SetFloat("Mouse", HBJJOCHGOPH);
			if (Bullet_1 < 1743f)
			{
				Bullet_1 = 1223f;
			}
			if (Bullet_2 < 1402f)
			{
				Bullet_2 = 1084f;
			}
			if (Bullet_3 < 247f)
			{
				Bullet_3 = 1359f;
			}
			if (Bullet_4 < 476f)
			{
				Bullet_4 = 618f;
			}
			if (Bullet_5 < 803f)
			{
				Bullet_5 = 1357f;
			}
			if (Bullet_6 < 1228f)
			{
				Bullet_6 = 1873f;
			}
			if (Bullet_7 < 427f)
			{
				Bullet_7 = 1278f;
			}
			if (Bullet_8 < 1559f)
			{
				Bullet_8 = 271f;
			}
			if (Bullet_9 < 1006f)
			{
				Bullet_9 = 1013f;
			}
			if (Bullet_10 < 1785f)
			{
				Bullet_10 = 612f;
			}
			if (Bullet_11 < 130f)
			{
				Bullet_11 = 528f;
			}
			if (Bullet_12 < 938f)
			{
				Bullet_12 = 431f;
			}
			if (Bullet_1 > 851f)
			{
				Bullet_1 = 811f;
			}
			if (Bullet_2 > 214f)
			{
				Bullet_2 = 1540f;
			}
			if (Bullet_3 > 899f)
			{
				Bullet_3 = 1708f;
			}
			if (Bullet_4 > 1396f)
			{
				Bullet_4 = 1534f;
			}
			if (Bullet_5 > 1700f)
			{
				Bullet_5 = 491f;
			}
			if (Bullet_6 > 858f)
			{
				Bullet_6 = 1170f;
			}
			if (Bullet_7 > 1662f)
			{
				Bullet_7 = 1445f;
			}
			if (Bullet_8 > 179f)
			{
				Bullet_8 = 1354f;
			}
			if (Bullet_9 > 463f)
			{
				Bullet_9 = 146f;
			}
			if (Bullet_10 > 922f)
			{
				Bullet_10 = 932f;
			}
			if (Bullet_11 > 1707f)
			{
				Bullet_11 = 164f;
			}
			if (Bullet_12 > 287f)
			{
				Bullet_12 = 129f;
			}
			LONNIJMNKFB().SetFloat("[LocalizationService] All languages: ", Bullet_1);
			HCGJCMDJPGD().SetFloat("shader.frost", Bullet_2);
			NDMPCDHADMJ().SetFloat("workshop.", Bullet_3);
			IIBLJCKLGFG().SetFloat("FileLabel", Bullet_4);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", Bullet_5);
			ADBKPGFMNKO().SetFloat(" #", Bullet_6);
			ADBKPGFMNKO().SetFloat(": ", Bullet_7);
			MFHPKGICPIO().SetFloat("_ScreenResolution", Bullet_8);
			DKNJGHFLAIF().SetFloat("maps.", Bullet_9);
			DKNJGHFLAIF().SetFloat("y", Bullet_10);
			IIBLJCKLGFG().SetFloat("_Green_R", Bullet_11);
			LONNIJMNKFB().SetFloat("SupportLogger OnJoinedRoom(", Bullet_12);
			IIBLJCKLGFG().SetTexture("mapselector.filter.rateduponly", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void HMNLHMLILKD()
	{
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void Update()
	{
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1341f)
			{
				HBJJOCHGOPH = 789f;
			}
			DBOLLHHMKKN().SetFloat("ChatHistoryInputField", HBJJOCHGOPH);
			if (Bullet_1 < 1539f)
			{
				Bullet_1 = 995f;
			}
			if (Bullet_2 < 653f)
			{
				Bullet_2 = 40f;
			}
			if (Bullet_3 < 40f)
			{
				Bullet_3 = 916f;
			}
			if (Bullet_4 < 73f)
			{
				Bullet_4 = 1663f;
			}
			if (Bullet_5 < 1677f)
			{
				Bullet_5 = 626f;
			}
			if (Bullet_6 < 773f)
			{
				Bullet_6 = 931f;
			}
			if (Bullet_7 < 920f)
			{
				Bullet_7 = 390f;
			}
			if (Bullet_8 < 1458f)
			{
				Bullet_8 = 1243f;
			}
			if (Bullet_9 < 794f)
			{
				Bullet_9 = 173f;
			}
			if (Bullet_10 < 1573f)
			{
				Bullet_10 = 1273f;
			}
			if (Bullet_11 < 1653f)
			{
				Bullet_11 = 1249f;
			}
			if (Bullet_12 < 1463f)
			{
				Bullet_12 = 914f;
			}
			if (Bullet_1 > 1995f)
			{
				Bullet_1 = 1826f;
			}
			if (Bullet_2 > 630f)
			{
				Bullet_2 = 990f;
			}
			if (Bullet_3 > 1450f)
			{
				Bullet_3 = 1356f;
			}
			if (Bullet_4 > 916f)
			{
				Bullet_4 = 406f;
			}
			if (Bullet_5 > 1654f)
			{
				Bullet_5 = 567f;
			}
			if (Bullet_6 > 1609f)
			{
				Bullet_6 = 1563f;
			}
			if (Bullet_7 > 1481f)
			{
				Bullet_7 = 918f;
			}
			if (Bullet_8 > 38f)
			{
				Bullet_8 = 1814f;
			}
			if (Bullet_9 > 279f)
			{
				Bullet_9 = 1511f;
			}
			if (Bullet_10 > 496f)
			{
				Bullet_10 = 1015f;
			}
			if (Bullet_11 > 704f)
			{
				Bullet_11 = 257f;
			}
			if (Bullet_12 > 625f)
			{
				Bullet_12 = 1679f;
			}
			OCHJIMJNEMO().SetFloat("ticket", Bullet_1);
			DBOLLHHMKKN().SetFloat("VoteDownToggle", Bullet_2);
			ADBKPGFMNKO().SetFloat("_TimeX", Bullet_3);
			NBPKMLMCHFN.SetFloat("_Distortion", Bullet_4);
			MFHPKGICPIO().SetFloat("Edited unlock conditions", Bullet_5);
			NDMPCDHADMJ().SetFloat("value", Bullet_6);
			IIBLJCKLGFG().SetFloat("offsets", Bullet_7);
			HCGJCMDJPGD().SetFloat("}", Bullet_8);
			DKNJGHFLAIF().SetFloat("Electronic", Bullet_9);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Antialiasing_FXAA", Bullet_10);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/NightVision_4", Bullet_11);
			LONNIJMNKFB().SetFloat("_TimeX", Bullet_12);
			OCHJIMJNEMO().SetTexture("value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1193f)
			{
				HBJJOCHGOPH = 1059f;
			}
			DKNJGHFLAIF().SetFloat("_Extra2", HBJJOCHGOPH);
			if (Bullet_1 < 1114f)
			{
				Bullet_1 = 1485f;
			}
			if (Bullet_2 < 15f)
			{
				Bullet_2 = 1526f;
			}
			if (Bullet_3 < 64f)
			{
				Bullet_3 = 1078f;
			}
			if (Bullet_4 < 1368f)
			{
				Bullet_4 = 961f;
			}
			if (Bullet_5 < 1430f)
			{
				Bullet_5 = 294f;
			}
			if (Bullet_6 < 1521f)
			{
				Bullet_6 = 1657f;
			}
			if (Bullet_7 < 569f)
			{
				Bullet_7 = 1947f;
			}
			if (Bullet_8 < 946f)
			{
				Bullet_8 = 1519f;
			}
			if (Bullet_9 < 1686f)
			{
				Bullet_9 = 857f;
			}
			if (Bullet_10 < 654f)
			{
				Bullet_10 = 1082f;
			}
			if (Bullet_11 < 841f)
			{
				Bullet_11 = 395f;
			}
			if (Bullet_12 < 743f)
			{
				Bullet_12 = 1265f;
			}
			if (Bullet_1 > 31f)
			{
				Bullet_1 = 929f;
			}
			if (Bullet_2 > 1439f)
			{
				Bullet_2 = 1623f;
			}
			if (Bullet_3 > 1125f)
			{
				Bullet_3 = 164f;
			}
			if (Bullet_4 > 1583f)
			{
				Bullet_4 = 1618f;
			}
			if (Bullet_5 > 1874f)
			{
				Bullet_5 = 1958f;
			}
			if (Bullet_6 > 1063f)
			{
				Bullet_6 = 1674f;
			}
			if (Bullet_7 > 614f)
			{
				Bullet_7 = 243f;
			}
			if (Bullet_8 > 343f)
			{
				Bullet_8 = 764f;
			}
			if (Bullet_9 > 1083f)
			{
				Bullet_9 = 1423f;
			}
			if (Bullet_10 > 1316f)
			{
				Bullet_10 = 1342f;
			}
			if (Bullet_11 > 1144f)
			{
				Bullet_11 = 1150f;
			}
			if (Bullet_12 > 1131f)
			{
				Bullet_12 = 1455f;
			}
			OCHJIMJNEMO().SetFloat("_LightIntensity", Bullet_1);
			DBOLLHHMKKN().SetFloat("Preparing configuration...", Bullet_2);
			LONNIJMNKFB().SetFloat("_TimeX", Bullet_3);
			NDMPCDHADMJ().SetFloat(" not exist", Bullet_4);
			OCHJIMJNEMO().SetFloat("_Value6", Bullet_5);
			HCGJCMDJPGD().SetFloat(".sav", Bullet_6);
			DBOLLHHMKKN().SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", Bullet_7);
			MFHPKGICPIO().SetFloat("return CheckCondition()", Bullet_8);
			LONNIJMNKFB().SetFloat("<b>HP</b>:", Bullet_9);
			OCHJIMJNEMO().SetFloat("_FixDistance", Bullet_10);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", Bullet_11);
			OCHJIMJNEMO().SetFloat("GlassAberration", Bullet_12);
			NBPKMLMCHFN.SetTexture("CameraFilterPack_OldFilm1", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
