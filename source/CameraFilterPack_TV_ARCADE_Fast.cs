// CameraFilterPack_TV_ARCADE_Fast
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/ARCADE_Fast")]
[ExecuteInEditMode]
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
		FPHEBLMINDA = Resources.Load("_OcclusionTexture") as Texture2D;
		SCShader = Shader.Find("float,1.5");
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
			CECJJMKLEAK().SetFloat(" Kb", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("2hands", Interferance_Size);
			KAFBNOBOIAJ().SetFloat("BitsData", Interferance_Speed);
			ADBKPGFMNKO().SetFloat("_ScreenResolution", Contrast);
			DKKBFFHBHJE().SetFloat("shader.future", Fade);
			OIMMPLPBLBK().SetVector("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 960f, 447f));
			CECJJMKLEAK().SetTexture("(scene)", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			DKNJGHFLAIF().SetFloat("_SoftZDistance", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("-1", Interferance_Size);
			NDMPCDHADMJ().SetFloat("/", Interferance_Speed);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Contrast);
			EPCGJFCCAFH().SetFloat("Set Sun MaxSize", Fade);
			EPBAAGMGPAP().SetVector("settings.volume.editor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 313f, 375f));
			FAIFBBGFAIB().SetTexture("[PlayerBase] Ready", FPHEBLMINDA);
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
			NLFJGMBCICG().SetFloat("_Value3", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("_ScreenResolution", Interferance_Size);
			GKILCDHJFEG().SetFloat("Committing changes...", Interferance_Speed);
			GKILCDHJFEG().SetFloat("float,10", Contrast);
			EPCGJFCCAFH().SetFloat("[PlayerController] ", Fade);
			OHKGGPFGLFD().SetVector("team", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1164f, 1999f));
			CECJJMKLEAK().SetTexture("https://steamcommunity.com/sharedfiles/filedetails/?id=", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGEJKLMJGDO()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("y");
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
		FPHEBLMINDA = Resources.Load("_Red_G") as Texture2D;
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
			FAIFBBGFAIB().SetFloat("Committing changes...", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("gold", Interferance_Size);
			OHKGGPFGLFD().SetFloat(".jpg", Interferance_Speed);
			LNLKMDPHDCC().SetFloat("Set sun lerp speed", Contrast);
			CECJJMKLEAK().SetFloat("_TimeX", Fade);
			NDMPCDHADMJ().SetVector("Cancel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1749f, 1121f));
			NBPKMLMCHFN.SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
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
			LMLENGFLEBD().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("music", Interferance_Size);
			MCDGIILBNIF().SetFloat("_Offsets", Interferance_Speed);
			GKILCDHJFEG().SetFloat("OnAwakeRPC", Contrast);
			GKILCDHJFEG().SetFloat("_Value3", Fade);
			EPBAAGMGPAP().SetVector("No Dispatcher exists in the scene. Actions will not be invoked!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 667f, 1630f));
			NBPKMLMCHFN.SetTexture("CameraFilterPack/Pixelisation_OilPaintHQ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			OHKGGPFGLFD().SetFloat("#C8C8C8FF", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("n/a", Interferance_Size);
			NBPKMLMCHFN.SetFloat("_ReprojectionMatrix", Interferance_Speed);
			MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Videoflip", Contrast);
			EPBAAGMGPAP().SetFloat("OpenButton", Fade);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 691f, 293f));
			ADBKPGFMNKO().SetTexture("_Visualize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_Darken") as Texture2D;
		SCShader = Shader.Find("mapselector.filter.subscribedonly");
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
		FPHEBLMINDA = Resources.Load("Run a command for data system") as Texture2D;
		SCShader = Shader.Find("_ChangeBlue");
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
			LMLENGFLEBD().SetFloat("ticket", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", Interferance_Size);
			PEIMCBBHLBJ().SetFloat("LoadingStatusText", Interferance_Speed);
			ADBKPGFMNKO().SetFloat("The observed monobehaviour (", Contrast);
			OHKGGPFGLFD().SetFloat("1159514800", Fade);
			KAFBNOBOIAJ().SetVector(" Remote called.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 753f, 1517f));
			EPBAAGMGPAP().SetTexture("downloading", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			PEIMCBBHLBJ().SetFloat(" not exist", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("skin.hit_normal", Interferance_Size);
			ADBKPGFMNKO().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", Interferance_Speed);
			JCPDCGIJKJD().SetFloat("leave", Contrast);
			JDMJJGEHMJO().SetFloat("Set sun min/max size", Fade);
			GKILCDHJFEG().SetVector("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 688f, 1529f));
			PEIMCBBHLBJ().SetTexture("Reload Maps", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
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
			DKNJGHFLAIF().SetFloat("/", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_TimeX", Interferance_Size);
			MCDGIILBNIF().SetFloat("z", Interferance_Speed);
			DKKBFFHBHJE().SetFloat("Bad parameters for getbool! Use <key> <value>", Contrast);
			JDMJJGEHMJO().SetFloat("RECORD [R]", Fade);
			PEIMCBBHLBJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1043f, 194f));
			FAIFBBGFAIB().SetTexture("SubmitUserVote:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load("/icon") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("#outdatedmap! Challenges will not work!");
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
			JDMJJGEHMJO().SetFloat("Data/Maps/", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("{0} days ago", Interferance_Size);
			EPCGJFCCAFH().SetFloat("_ScreenResolution", Interferance_Speed);
			EPBAAGMGPAP().SetFloat("owner: ", Contrast);
			GKILCDHJFEG().SetFloat("CameraFilterPack/TV_Vignetting", Fade);
			CECJJMKLEAK().SetVector("Can not SetMasterClient(). Not in room or in offlineMode.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1293f, 1494f));
			JDMJJGEHMJO().SetTexture("_DistortionSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			DKNJGHFLAIF().SetFloat("_Value", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_Blue_G", Interferance_Size);
			GKILCDHJFEG().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", Interferance_Speed);
			NDMPCDHADMJ().SetFloat("Set Trail Zoom Speed", Contrast);
			JDMJJGEHMJO().SetFloat("#exitmapeditor", Fade);
			HBLDMJCOAHA().SetVector("settings.enableselectormusic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 52f, 1103f));
			DBOLLHHMKKN().SetTexture("custom", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("[ItemsHandler] Item not found:");
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
			EPBAAGMGPAP().SetFloat("Texture2", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("[EditorEvent] Exception: ", Interferance_Size);
			NLFJGMBCICG().SetFloat("_Tint", Interferance_Speed);
			JDMJJGEHMJO().SetFloat("\n", Contrast);
			PEIMCBBHLBJ().SetFloat("action", Fade);
			CECJJMKLEAK().SetVector("_Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 455f, 455f));
			PEIMCBBHLBJ().SetTexture("_Blue_B", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("<command>") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_ColorDodge");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMEOGJHCONJ()
	{
		FPHEBLMINDA = Resources.Load("[MapEditor] Importing map: ") as Texture2D;
		SCShader = Shader.Find("DeleteButton");
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
			HBLDMJCOAHA().SetFloat("2", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat(" - {0}", Interferance_Size);
			HEINDEMCGIK().SetFloat(".workshop.json", Interferance_Speed);
			KAFBNOBOIAJ().SetFloat("--------------------------------", Contrast);
			CECJJMKLEAK().SetFloat("_Value3", Fade);
			CECJJMKLEAK().SetVector("settings.volume.game", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1833f, 641f));
			LNLKMDPHDCC().SetTexture("workshop.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			DKKBFFHBHJE().SetFloat("_Value1", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("BitsData", Interferance_Size);
			LNLKMDPHDCC().SetFloat("USE_DIAG_SEARCH", Interferance_Speed);
			GKILCDHJFEG().SetFloat("_Value", Contrast);
			MCDGIILBNIF().SetFloat("3d text", Fade);
			EPBAAGMGPAP().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 841f, 1737f));
			DKKBFFHBHJE().SetTexture("Uploader", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
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
			NLFJGMBCICG().SetFloat("_DistanceParams", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_TimeX", Interferance_Size);
			FAIFBBGFAIB().SetFloat("_Glitch", Interferance_Speed);
			DKKBFFHBHJE().SetFloat("[MapsData] Bad map: ", Contrast);
			JCPDCGIJKJD().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", Fade);
			DBOLLHHMKKN().SetVector("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 645f, 1661f));
			MCDGIILBNIF().SetTexture("open", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			OHKGGPFGLFD().SetFloat("CameraFilterPack/FX_Hypno", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("player.abstract", Interferance_Size);
			MNLKBFFKHIE().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", Interferance_Speed);
			MCDGIILBNIF().SetFloat("_CurveParams", Contrast);
			NLFJGMBCICG().SetFloat("_FresnelFadePower", Fade);
			NDMPCDHADMJ().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 590f, 1731f));
			JCPDCGIJKJD().SetTexture("_Distortion", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_ForegroundBlurExtrude");
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
			MCDGIILBNIF().SetFloat("HighScaleShot", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("Other", Interferance_Size);
			JCPDCGIJKJD().SetFloat("1", Interferance_Speed);
			DKKBFFHBHJE().SetFloat("_Distortion", Contrast);
			HEINDEMCGIK().SetFloat("_MinVelocity", Fade);
			KAFBNOBOIAJ().SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1678f, 542f));
			LMLENGFLEBD().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			DBOLLHHMKKN().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("Error: Someone else(", Interferance_Size);
			NDMPCDHADMJ().SetFloat("threshold", Interferance_Speed);
			FAIFBBGFAIB().SetFloat("Editor/", Contrast);
			NDMPCDHADMJ().SetFloat("Done!", Fade);
			EPBAAGMGPAP().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1624f, 1668f));
			DKNJGHFLAIF().SetTexture(": ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPBAAGMGPAP());
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
		FPHEBLMINDA = Resources.Load("LevelNameText") as Texture2D;
		SCShader = Shader.Find("_Value4");
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
			DKKBFFHBHJE().SetFloat("TStart", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("Incoming: \n", Interferance_Size);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", Interferance_Speed);
			DKKBFFHBHJE().SetFloat("player.neon", Contrast);
			MCDGIILBNIF().SetFloat("CameraFilterPack/3D_Myst", Fade);
			PEIMCBBHLBJ().SetVector(" = ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 616f, 426f));
			DKNJGHFLAIF().SetTexture("_Distortion", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
		SCShader = Shader.Find("Updated!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load("GlassesColor") as Texture2D;
		SCShader = Shader.Find("SpawnObj");
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
			LMLENGFLEBD().SetFloat("Drop_With_Obj", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("BitsData", Interferance_Size);
			JDMJJGEHMJO().SetFloat("_ScreenResolution", Interferance_Speed);
			LMLENGFLEBD().SetFloat("FileMenu", Contrast);
			DKKBFFHBHJE().SetFloat("[PlayerBase] SetPlayerDistance error: ", Fade);
			MNLKBFFKHIE().SetVector("No regions available. Are you sure your appid is valid and setup?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 960f, 496f));
			EPBAAGMGPAP().SetTexture("EXCEPTION:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			JCPDCGIJKJD().SetFloat("#exit", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("id", Interferance_Size);
			EPCGJFCCAFH().SetFloat("Default UI Material", Interferance_Speed);
			NBPKMLMCHFN.SetFloat("_TimeX", Contrast);
			CECJJMKLEAK().SetFloat("editor.", Fade);
			HEINDEMCGIK().SetVector("_ClutTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1612f, 54f));
			MCDGIILBNIF().SetTexture("Illegal view ID:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
		SCShader = Shader.Find("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.");
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
			OHKGGPFGLFD().SetFloat("_CurveTex", HBJJOCHGOPH);
			JDMJJGEHMJO().SetFloat(" ", Interferance_Size);
			EPBAAGMGPAP().SetFloat("_Bullet_11", Interferance_Speed);
			NBPKMLMCHFN.SetFloat("Bad parameters for getbool! Use <key> <value>", Contrast);
			DBOLLHHMKKN().SetFloat("_Value4", Fade);
			MCDGIILBNIF().SetVector("Mouse Y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1581f, 256f));
			DKNJGHFLAIF().SetTexture("Set Sun Lerp Speed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		FPHEBLMINDA = Resources.Load("Editor/") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Distortion_Aspiration");
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
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Distortion_Dream", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("-1", Interferance_Size);
			NDMPCDHADMJ().SetFloat("<size=24>", Interferance_Speed);
			MNLKBFFKHIE().SetFloat("_Saturation", Contrast);
			DBOLLHHMKKN().SetFloat("Fade", Fade);
			FAIFBBGFAIB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 738f, 1517f));
			FAIFBBGFAIB().SetTexture("_SunColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
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
		FPHEBLMINDA = Resources.Load("X") as Texture2D;
		SCShader = Shader.Find("_Distance");
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
			PEIMCBBHLBJ().SetFloat("#FFDA44CC", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", Interferance_Size);
			OHKGGPFGLFD().SetFloat("OperationResponse ignored while disconnecting. Code: ", Interferance_Speed);
			DBOLLHHMKKN().SetFloat("[LevelEditorScene] Print Audio Wave: Start", Contrast);
			EPBAAGMGPAP().SetFloat("_ScreenResolution", Fade);
			EPBAAGMGPAP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1961f, 194f));
			JDMJJGEHMJO().SetTexture("/../", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			NBPKMLMCHFN.SetFloat("score:", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("inventory.selected.", Interferance_Size);
			OIMMPLPBLBK().SetFloat(". Calling ConnectToRegionMaster() is: ", Interferance_Speed);
			EPCGJFCCAFH().SetFloat("Jump", Contrast);
			JCPDCGIJKJD().SetFloat("challenges.", Fade);
			NDMPCDHADMJ().SetVector("Parent ID", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1022f, 279f));
			CECJJMKLEAK().SetTexture("BitsData", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			LMLENGFLEBD().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("x", Interferance_Size);
			NBPKMLMCHFN.SetFloat("_SpawnHeuristic", Interferance_Speed);
			ADBKPGFMNKO().SetFloat("?", Contrast);
			OHKGGPFGLFD().SetFloat("Hex value #RRGGBB", Fade);
			PEIMCBBHLBJ().SetVector("CameraFilterPack/Drawing_Manga2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 132f, 1372f));
			FAIFBBGFAIB().SetTexture("DISTORT", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			OHKGGPFGLFD().SetFloat("_TimeX", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("float,0", Interferance_Size);
			OHKGGPFGLFD().SetFloat("1234332714", Interferance_Speed);
			FAIFBBGFAIB().SetFloat("input", Contrast);
			JDMJJGEHMJO().SetFloat("[Left]", Fade);
			HBLDMJCOAHA().SetVector("sounds/hit_wrong", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 708f, 703f));
			MNLKBFFKHIE().SetTexture("Curve texture", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKIGIIINEDH()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("error");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEGJMDDIDIC()
	{
		FPHEBLMINDA = Resources.Load("&page=") as Texture2D;
		SCShader = Shader.Find("_Blue_R");
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
		SCShader = Shader.Find("_CenterX");
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
			MCDGIILBNIF().SetFloat("_Value", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("[EditorEvent] Exception: ", Interferance_Size);
			OHKGGPFGLFD().SetFloat("offsets", Interferance_Speed);
			NBPKMLMCHFN.SetFloat("y", Contrast);
			HEINDEMCGIK().SetFloat("CameraFilterPack_Glasses_On7", Fade);
			DKNJGHFLAIF().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1912f, 1439f));
			FAIFBBGFAIB().SetTexture("[Up-Right-Down-Left]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			DKKBFFHBHJE().SetFloat(".lastCheckpoint.correctScore", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat(" ", Interferance_Size);
			LMLENGFLEBD().SetFloat("_Value4", Interferance_Speed);
			JDMJJGEHMJO().SetFloat("_OcclusionBlurTexture", Contrast);
			OIMMPLPBLBK().SetFloat("SetSatelliteTrailMinVertexDistance", Fade);
			NDMPCDHADMJ().SetVector("list", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 540f, 864f));
			DKNJGHFLAIF().SetTexture("Rock", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
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
			HEINDEMCGIK().SetFloat("_Value", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_Distortion", Interferance_Size);
			DKNJGHFLAIF().SetFloat("_Value6", Interferance_Speed);
			JCPDCGIJKJD().SetFloat(" GameServer:", Contrast);
			KAFBNOBOIAJ().SetFloat("Joystick1Button2", Fade);
			EPBAAGMGPAP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 440f, 1071f));
			MCDGIILBNIF().SetTexture(":", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("Error: Timeout :S");
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
