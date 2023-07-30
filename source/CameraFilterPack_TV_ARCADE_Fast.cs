// CameraFilterPack_TV_ARCADE_Fast
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/ARCADE_Fast")]
public class CameraFilterPack_TV_ARCADE_Fast : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 0.05f)]
	public float Interferance_Size = 0.02f;

	[Range(0f, 4f)]
	public float Interferance_Speed = 0.5f;

	[Range(0f, 10f)]
	public float Contrast = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void MBLDJEFBLFL()
	{
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	private void MDNHCLKNCLE()
	{
		FPHEBLMINDA = Resources.Load("_BlurVector") as Texture2D;
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 333f)
			{
				HBJJOCHGOPH = 1303f;
			}
			KAFBNOBOIAJ().SetFloat("#.##", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("UI", Interferance_Size);
			DKKBFFHBHJE().SetFloat("BitsData", Interferance_Speed);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", Contrast);
			FAIFBBGFAIB().SetFloat("shader.future", Fade);
			PEIMCBBHLBJ().SetVector("Tried to Initialize the SteamAPI twice in one session!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 960f, 447f));
			GKILCDHJFEG().SetTexture(") of this PhotonView does not implement OnPhotonSerializeView()!", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
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
			if (HBJJOCHGOPH > 407f)
			{
				HBJJOCHGOPH = 1172f;
			}
			JCPDCGIJKJD().SetFloat("_VelTex", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("-1", Interferance_Size);
			MNLKBFFKHIE().SetFloat(".", Interferance_Speed);
			HEINDEMCGIK().SetFloat("_ScreenResolution", Contrast);
			DBOLLHHMKKN().SetFloat("SetSunMaxSize", Fade);
			CECJJMKLEAK().SetVector("settings.volume.sfx", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 313f, 375f));
			LMLENGFLEBD().SetTexture("[Up]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 788f)
			{
				HBJJOCHGOPH = 274f;
			}
			NLFJGMBCICG().SetFloat("_Value2", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_ScreenResolution", Interferance_Size);
			EPBAAGMGPAP().SetFloat("#failed!", Interferance_Speed);
			CECJJMKLEAK().SetFloat("float,10", Contrast);
			MNLKBFFKHIE().SetFloat(" not exist", Fade);
			LMLENGFLEBD().SetVector("JoinTeam was called in state: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1164f, 1999f));
			MCDGIILBNIF().SetTexture("Item invalid. Make sure your mod contains at leats one file.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGEJKLMJGDO()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("b");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CAKNMILHHNE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void KFACDBHDAOD()
	{
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGJJDKENBNC()
	{
		FPHEBLMINDA = Resources.Load("_Red_R") as Texture2D;
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1724f)
			{
				HBJJOCHGOPH = 30f;
			}
			PEIMCBBHLBJ().SetFloat("Item invalid. No idea why.", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("white", Interferance_Size);
			OIMMPLPBLBK().SetFloat(" not found", Interferance_Speed);
			JDMJJGEHMJO().SetFloat("float,1", Contrast);
			GKILCDHJFEG().SetFloat("CameraFilterPack/FX_EarthQuake", Fade);
			DKNJGHFLAIF().SetVector("Vertical", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1749f, 1121f));
			EPCGJFCCAFH().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODLMOJDBPPG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void KFMEAMBLODG()
	{
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 637f)
			{
				HBJJOCHGOPH = 1977f;
			}
			MNLKBFFKHIE().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("/", Interferance_Size);
			GKILCDHJFEG().SetFloat("_OffsetScale", Interferance_Speed);
			DBOLLHHMKKN().SetFloat("<color=white>", Contrast);
			NLFJGMBCICG().SetFloat("_Value3", Fade);
			OHKGGPFGLFD().SetVector("d264dbba9c2410771b4ad918903b3f4cd9e276a9", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 667f, 1630f));
			OIMMPLPBLBK().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1052f)
			{
				HBJJOCHGOPH = 1906f;
			}
			CECJJMKLEAK().SetFloat("#8E8E8EFF", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("3d text", Interferance_Size);
			JCPDCGIJKJD().SetFloat("_Params1", Interferance_Speed);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Contrast);
			EPBAAGMGPAP().SetFloat(" ", Fade);
			PEIMCBBHLBJ().SetVector("CameraFilterPack/Oculus_NightVision3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 691f, 293f));
			FAIFBBGFAIB().SetTexture("_LightIntensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_Darken") as Texture2D;
		SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EPBAAGMGPAP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("subscribeall") as Texture2D;
		SCShader = Shader.Find("_ChangeGreen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1277f)
			{
				HBJJOCHGOPH = 1678f;
			}
			NLFJGMBCICG().SetFloat("<command>", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("CloseConnection: Only the masterclient can kick another player.", Interferance_Size);
			LMLENGFLEBD().SetFloat("LoadingStatusText", Interferance_Speed);
			DBOLLHHMKKN().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Contrast);
			NBPKMLMCHFN.SetFloat("1332644700", Fade);
			MNLKBFFKHIE().SetVector(" but this PhotonView does not exist! Was remote PV.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 753f, 1517f));
			PEIMCBBHLBJ().SetTexture("downloading", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPBAAGMGPAP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1193f)
			{
				HBJJOCHGOPH = 567f;
			}
			LMLENGFLEBD().SetFloat(": ", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("sounds/hit_perfect", Interferance_Size);
			GKILCDHJFEG().SetFloat(" to: ", Interferance_Speed);
			LMLENGFLEBD().SetFloat("tolobby", Contrast);
			HBLDMJCOAHA().SetFloat("float,1.5", Fade);
			EPCGJFCCAFH().SetVector("Can not SetMasterClient(). Not in room or in offlineMode.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 688f, 1529f));
			OHKGGPFGLFD().SetTexture("Reset XP", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JFMIDILENDO()
	{
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void PFNFPINPCMH()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1f)
			{
				HBJJOCHGOPH = 119f;
			}
			KAFBNOBOIAJ().SetFloat("menu.tabid", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_TimeX", Interferance_Size);
			EPCGJFCCAFH().SetFloat("float,0", Interferance_Speed);
			DKKBFFHBHJE().SetFloat("getfloat", Contrast);
			MNLKBFFKHIE().SetFloat("MenuRecordButton", Fade);
			DKNJGHFLAIF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1043f, 194f));
			LNLKMDPHDCC().SetTexture("?", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load("/music") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void EHJJFJCKGAJ()
	{
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("\\") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1163f)
			{
				HBJJOCHGOPH = 544f;
			}
			OIMMPLPBLBK().SetFloat(" base map(s)", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("an hour ago", Interferance_Size);
			CECJJMKLEAK().SetFloat("Fade", Interferance_Speed);
			JCPDCGIJKJD().SetFloat("ViewID {0} {1}{2}", Contrast);
			HEINDEMCGIK().SetFloat("_TimeX", Fade);
			ADBKPGFMNKO().SetVector("CloseConnection: Only the masterclient can kick another player.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1293f, 1494f));
			NBPKMLMCHFN.SetTexture("_DistortionLevel", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
			NBPKMLMCHFN.SetFloat("_Value", Interferance_Size);
			NBPKMLMCHFN.SetFloat("_Value2", Interferance_Speed);
			NBPKMLMCHFN.SetFloat("_Value3", Contrast);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BDBFMPGAKCE()
	{
	}

	private void CFIAKIJAILI()
	{
	}

	private void IKKOIKKIDEG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 950f)
			{
				HBJJOCHGOPH = 457f;
			}
			NDMPCDHADMJ().SetFloat("_TimeX", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Blue_R", Interferance_Size);
			DKKBFFHBHJE().SetFloat(" Time: ", Interferance_Speed);
			KAFBNOBOIAJ().SetFloat("SetTrailZoomSpeed", Contrast);
			ADBKPGFMNKO().SetFloat("MenuScene", Fade);
			NBPKMLMCHFN.SetVector("settings.disablestoryboard", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 52f, 1103f));
			PEIMCBBHLBJ().SetTexture("UI", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void GFACKFCEIBC()
	{
	}

	private void DPLLKHHLDBB()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Drawing_Lines") as Texture2D;
		SCShader = Shader.Find("inventory.itemscash");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 388f)
			{
				HBJJOCHGOPH = 832f;
			}
			DBOLLHHMKKN().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_EmissionColor", Interferance_Size);
			KAFBNOBOIAJ().SetFloat("_PosY", Interferance_Speed);
			LNLKMDPHDCC().SetFloat("Hello World, is my item a clone? [", Contrast);
			DKNJGHFLAIF().SetFloat("menuVolume", Fade);
			DKNJGHFLAIF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 455f, 455f));
			JDMJJGEHMJO().SetTexture("_Blue_G", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JDMJJGEHMJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void CIHGFHNNFEE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFAFJKJAEEL()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		FPHEBLMINDA = Resources.Load("ls") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMEOGJHCONJ()
	{
		FPHEBLMINDA = Resources.Load("Editor") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KPBKHFNLNBA()
	{
	}

	private void HCIPECAOGIA()
	{
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void ALJEADNKJPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MANDOGNJJBD()
	{
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1806f)
			{
				HBJJOCHGOPH = 1439f;
			}
			KAFBNOBOIAJ().SetFloat("11", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("{0}", Interferance_Size);
			DKNJGHFLAIF().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", Interferance_Speed);
			LNLKMDPHDCC().SetFloat("MapConfig", Contrast);
			NLFJGMBCICG().SetFloat("_Value2", Fade);
			ADBKPGFMNKO().SetVector("settings.volume.editor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1833f, 641f));
			GKILCDHJFEG().SetTexture(".played", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PEIMCBBHLBJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void COMNAPAAPDO()
	{
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void EFECEKPFOEM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 87f)
			{
				HBJJOCHGOPH = 91f;
			}
			MCDGIILBNIF().SetFloat("_PColor", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("event", Interferance_Size);
			LMLENGFLEBD().SetFloat("USE_DIAG_SEARCH", Interferance_Speed);
			MCDGIILBNIF().SetFloat("_TimeX", Contrast);
			DKKBFFHBHJE().SetFloat("fetch", Fade);
			LNLKMDPHDCC().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 841f, 1737f));
			DBOLLHHMKKN().SetTexture(".workshop.json", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1669f)
			{
				HBJJOCHGOPH = 1533f;
			}
			CECJJMKLEAK().SetFloat("_CameraWS", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("_TimeX", Interferance_Size);
			MCDGIILBNIF().SetFloat("_Glitch", Interferance_Speed);
			OIMMPLPBLBK().SetFloat("Data/Maps/", Contrast);
			DBOLLHHMKKN().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", Fade);
			ADBKPGFMNKO().SetVector("PhotonView with ID ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 645f, 1661f));
			NBPKMLMCHFN.SetTexture("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 28f)
			{
				HBJJOCHGOPH = 989f;
			}
			EPBAAGMGPAP().SetFloat("CameraFilterPack/FX_Hypno", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("player.rgb", Interferance_Size);
			FAIFBBGFAIB().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", Interferance_Speed);
			PEIMCBBHLBJ().SetFloat("_Offsets", Contrast);
			MNLKBFFKHIE().SetFloat("_SSRMultiplier", Fade);
			EPBAAGMGPAP().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 590f, 1731f));
			LNLKMDPHDCC().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_FgOverlap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1778f)
			{
				HBJJOCHGOPH = 1410f;
			}
			EPCGJFCCAFH().SetFloat("HighScaleShot", HBJJOCHGOPH);
			HBLDMJCOAHA().SetFloat("Other", Interferance_Size);
			EPBAAGMGPAP().SetFloat("finished", Interferance_Speed);
			GKILCDHJFEG().SetFloat("_Speed", Contrast);
			KAFBNOBOIAJ().SetFloat("_MaxVelocity", Fade);
			JCPDCGIJKJD().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1678f, 542f));
			DKNJGHFLAIF().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPBAAGMGPAP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void AEMGPJDJGBJ()
	{
		FPHEBLMINDA = Resources.Load("\\") as Texture2D;
		SCShader = Shader.Find("speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1555f)
			{
				HBJJOCHGOPH = 146f;
			}
			DKNJGHFLAIF().SetFloat("_Smooth", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("Ev OwnershipTransfer. ViewID ", Interferance_Size);
			OHKGGPFGLFD().SetFloat("_MainTexBlurred", Interferance_Speed);
			HEINDEMCGIK().SetFloat("editor.", Contrast);
			EPBAAGMGPAP().SetFloat("Sprite", Fade);
			NBPKMLMCHFN.SetVector("[TextSaver] Text saved to ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1624f, 1668f));
			LNLKMDPHDCC().SetTexture("[PlayerController] ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void KMIEAGOFLBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void IBFJAOINHMK()
	{
	}

	private void BGDONBMDPGM()
	{
	}

	private void JOHOFNKJDEB()
	{
		FPHEBLMINDA = Resources.Load("NameInfoText") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 467f)
			{
				HBJJOCHGOPH = 629f;
			}
			LNLKMDPHDCC().SetFloat("move", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("Reset", Interferance_Size);
			HBLDMJCOAHA().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", Interferance_Speed);
			FAIFBBGFAIB().SetFloat("player.neon", Contrast);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/3D_Myst", Fade);
			EPBAAGMGPAP().SetVector("The number of objects sent via a PhotonStreamQueue has to be the same each frame", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 616f, 426f));
			HBLDMJCOAHA().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HBLDMJCOAHA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void FHGKIOOMMOH()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("[LevelEditorScene] Updated");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load("GlassAberration") as Texture2D;
		SCShader = Shader.Find("[Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 31f)
			{
				HBJJOCHGOPH = 905f;
			}
			NBPKMLMCHFN.SetFloat("Drop_With_Obj", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("BitsData", Interferance_Size);
			LMLENGFLEBD().SetFloat("_Value3", Interferance_Speed);
			EPBAAGMGPAP().SetFloat("FileMenu", Contrast);
			HEINDEMCGIK().SetFloat("[PlayerBase] Invoke event ", Fade);
			NBPKMLMCHFN.SetVector(" Server: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 960f, 496f));
			DKKBFFHBHJE().SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABFNJCEBIKA()
	{
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 649f)
			{
				HBJJOCHGOPH = 1730f;
			}
			CECJJMKLEAK().SetFloat("#tryagain", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("id", Interferance_Size);
			DKNJGHFLAIF().SetFloat("UI Extensions/UIScreen", Interferance_Speed);
			LMLENGFLEBD().SetFloat("_MainTex2", Contrast);
			MNLKBFFKHIE().SetFloat("Editor/", Fade);
			EPCGJFCCAFH().SetVector("_Scale", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1612f, 54f));
			DKNJGHFLAIF().SetTexture("Cannot remove cached RPCs on a PhotonView thats not ours! ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DNENFLNCIJP()
	{
	}

	private void NFEDLAOPHML()
	{
	}

	private void FOMNCPKKCFN()
	{
	}

	private void DKEHGPPOKEA()
	{
		FPHEBLMINDA = Resources.Load("_Value1") as Texture2D;
		SCShader = Shader.Find("Can not SetMasterClient(). Not in room or in offlineMode.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_Arcade1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_ARCADE_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void KPNKCNJBMKB()
	{
	}

	private void LKJMIODJGCM()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1958f)
			{
				HBJJOCHGOPH = 1747f;
			}
			KAFBNOBOIAJ().SetFloat("_ChannelMixerGreen", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("Item ", Interferance_Size);
			JDMJJGEHMJO().SetFloat("_Bullet_10", Interferance_Speed);
			LMLENGFLEBD().SetFloat("Bad parameters for getbool! Use <key> <value>", Contrast);
			GKILCDHJFEG().SetFloat("_Value3", Fade);
			JCPDCGIJKJD().SetVector("Mouse X", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1581f, 256f));
			DKNJGHFLAIF().SetTexture("SetSunLerpSpeed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void Update()
	{
	}

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODCJJFBJJNF()
	{
	}

	private void NEFHGMNAPEP()
	{
		FPHEBLMINDA = Resources.Load("Data/Editor/leveltemplate") as Texture2D;
		SCShader = Shader.Find("_Intervale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void GGPDKCHEBAG()
	{
	}

	private void IBKFIFHFMFF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1728f)
			{
				HBJJOCHGOPH = 1424f;
			}
			FAIFBBGFAIB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HBLDMJCOAHA().SetFloat("GetLive", Interferance_Size);
			HEINDEMCGIK().SetFloat("<size=24>", Interferance_Speed);
			NLFJGMBCICG().SetFloat("_ZCurve", Contrast);
			EPCGJFCCAFH().SetFloat("Fade", Fade);
			HEINDEMCGIK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 738f, 1517f));
			ADBKPGFMNKO().SetTexture("_BlurRadius4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PEDHPEMNHBF()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button0") as Texture2D;
		SCShader = Shader.Find("_Level");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1564f)
			{
				HBJJOCHGOPH = 533f;
			}
			MNLKBFFKHIE().SetFloat("#000000CC", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", Interferance_Size);
			FAIFBBGFAIB().SetFloat("HandleEventLeave for player ID: ", Interferance_Speed);
			HEINDEMCGIK().SetFloat("#exitmapeditor", Contrast);
			KAFBNOBOIAJ().SetFloat("_Distortion2", Fade);
			JCPDCGIJKJD().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1961f, 194f));
			DKNJGHFLAIF().SetTexture("/../", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANDELGODEOC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1716f)
			{
				HBJJOCHGOPH = 1866f;
			}
			NLFJGMBCICG().SetFloat("score:", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("inventory.selected.", Interferance_Size);
			DKKBFFHBHJE().SetFloat("Found best region: '", Interferance_Speed);
			NLFJGMBCICG().SetFloat("Backward", Contrast);
			OIMMPLPBLBK().SetFloat(".completedCount", Fade);
			HEINDEMCGIK().SetVector("Parent ID", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1022f, 279f));
			LNLKMDPHDCC().SetTexture("BitsData", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1479f)
			{
				HBJJOCHGOPH = 1499f;
			}
			HEINDEMCGIK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("b", Interferance_Size);
			NLFJGMBCICG().SetFloat("_Offsets", Interferance_Speed);
			EPBAAGMGPAP().SetFloat("-1", Contrast);
			DKKBFFHBHJE().SetFloat("Hex value #RRGGBB", Fade);
			DKKBFFHBHJE().SetVector("CameraFilterPack/Drawing_Manga2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 132f, 1372f));
			ADBKPGFMNKO().SetTexture("_VignetteColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 96f)
			{
				HBJJOCHGOPH = 18f;
			}
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Film_ColorPerfection", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("z", Interferance_Size);
			EPCGJFCCAFH().SetFloat("907198288", Interferance_Speed);
			HEINDEMCGIK().SetFloat("Object ID. Case-Sensitive", Contrast);
			MCDGIILBNIF().SetFloat("[Right]", Fade);
			FAIFBBGFAIB().SetVector("skin.no_hit", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 708f, 703f));
			OIMMPLPBLBK().SetTexture("_Axis", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKIGIIINEDH()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEGJMDDIDIC()
	{
		FPHEBLMINDA = Resources.Load("&page=") as Texture2D;
		SCShader = Shader.Find("_Green_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void JOACBIEHHCE()
	{
	}

	private void PBIGHNGAAID()
	{
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1152f)
			{
				HBJJOCHGOPH = 102f;
			}
			NLFJGMBCICG().SetFloat("_TimeX", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("[EditorEvent] Exception: ", Interferance_Size);
			OIMMPLPBLBK().SetFloat("offsets", Interferance_Speed);
			KAFBNOBOIAJ().SetFloat("float,0", Contrast);
			EPCGJFCCAFH().SetFloat("_MainTex2", Fade);
			OIMMPLPBLBK().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1912f, 1439f));
			MNLKBFFKHIE().SetTexture("[Up-Down-Left]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 474f)
			{
				HBJJOCHGOPH = 1644f;
			}
			LNLKMDPHDCC().SetFloat(".lastCheckpoint.lives", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("_Value4", Interferance_Size);
			DKKBFFHBHJE().SetFloat("_Value4", Interferance_Speed);
			PEIMCBBHLBJ().SetFloat("AmbientOcclusion", Contrast);
			LNLKMDPHDCC().SetFloat("SetSatelliteLerpSpeed", Fade);
			NBPKMLMCHFN.SetVector("keys", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 540f, 864f));
			FAIFBBGFAIB().SetTexture("Rap", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1551f)
			{
				HBJJOCHGOPH = 542f;
			}
			JDMJJGEHMJO().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Vignette_Alpha", Interferance_Size);
			NBPKMLMCHFN.SetFloat("_Value6", Interferance_Speed);
			NDMPCDHADMJ().SetFloat("SupportLogger OnCreatedRoom(", Contrast);
			NDMPCDHADMJ().SetFloat("Cross", Fade);
			JCPDCGIJKJD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 440f, 1071f));
			LNLKMDPHDCC().SetTexture(":", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("_FarCamera") as Texture2D;
		SCShader = Shader.Find("Item creation successful! Published Item ID: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}
}
