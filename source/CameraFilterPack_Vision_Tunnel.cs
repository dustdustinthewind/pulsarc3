// CameraFilterPack_Vision_Tunnel
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Tunnel")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Tunnel : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Value = 0.6f;

	[Range(0f, 1f)]
	public float Value2 = 0.4f;

	[Range(0f, 1f)]
	public float Intensity = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void FABKIGNFECE()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 173f)
			{
				HBJJOCHGOPH = 224f;
			}
			IONHGBPGCHK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Value4", Value);
			GCDFNHMJMIP().SetFloat(": ", Value2);
			KBOPGONOCNP().SetFloat("_Value6", Intensity);
			IONHGBPGCHK().SetFloat("GameVolumeSlider", CCIENBFIKKH);
			IONHGBPGCHK().SetVector("ICollection", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1626f, 976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 628f)
			{
				HBJJOCHGOPH = 1359f;
			}
			KAFBNOBOIAJ().SetFloat("float,0", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", Value);
			NBPKMLMCHFN.SetFloat("_MainTex2", Value2);
			NBPKMLMCHFN.SetFloat("GameScene", Intensity);
			IONHGBPGCHK().SetFloat("IntraTime", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1050f, 1641f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
			NBPKMLMCHFN.SetFloat("_Value2", Value2);
			NBPKMLMCHFN.SetFloat("_Value3", Intensity);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1218f)
			{
				HBJJOCHGOPH = 1740f;
			}
			NBMPPNFKFLB().SetFloat(".", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("mapselector.filter.subscribedonly", Value);
			MMOODGIODPC().SetFloat("_Value2", Value2);
			KBOPGONOCNP().SetFloat("_Amount", Intensity);
			MFHPKGICPIO().SetFloat("_ScreenResolution", CCIENBFIKKH);
			MFHPKGICPIO().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 408f, 881f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MAOCOEGAFND()
	{
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void HDDECCMEJKA()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1585f)
			{
				HBJJOCHGOPH = 860f;
			}
			KBOPGONOCNP().SetFloat("UseScanLineSize", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("#rt", Value);
			NBPKMLMCHFN.SetFloat("_SpherePositionX", Value2);
			IONHGBPGCHK().SetFloat("[MapEditor] Loading events...", Intensity);
			MMOODGIODPC().SetFloat("error", CCIENBFIKKH);
			IONHGBPGCHK().SetVector("_CameraWS", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1508f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Tunnel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("] to be droppable");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1353f)
			{
				HBJJOCHGOPH = 841f;
			}
			HCGJCMDJPGD().SetFloat("BestRegion checks region: ", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("inventory.itemscash", Value);
			NBPKMLMCHFN.SetFloat("_Distortion", Value2);
			GCDFNHMJMIP().SetFloat("menu.playedsolo", Intensity);
			IONHGBPGCHK().SetFloat("_VelocityTex", CCIENBFIKKH);
			JLHLHKPHDFO().SetVector("settings.crosshairopacity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 468f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void AEEGKLABFLN()
	{
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1576f)
			{
				HBJJOCHGOPH = 1548f;
			}
			IONHGBPGCHK().SetFloat("_EmissionGain", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CurrentTimeLabel", Value);
			EOCCJGIGEGJ().SetFloat("_CenterRadius", Value2);
			KAFBNOBOIAJ().SetFloat(". The group number should be at least 1.", Intensity);
			HCGJCMDJPGD().SetFloat("SupportLogger OnDisconnectedFromPhoton().", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("mapselector.filter.rateduponly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 694f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("MapperNameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1928f)
			{
				HBJJOCHGOPH = 1186f;
			}
			MMOODGIODPC().SetFloat("Right", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Players NetIDs:", Value);
			IONHGBPGCHK().SetFloat("menu.tabid", Value2);
			GCDFNHMJMIP().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", Intensity);
			EOCCJGIGEGJ().SetFloat("_Blue_G", CCIENBFIKKH);
			EOCCJGIGEGJ().SetVector("Edited unlock conditions", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1860f, 1065f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return BJFKDHHMLJH;
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("CameraFilterPack/Gradients_Desert");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 730f)
			{
				HBJJOCHGOPH = 430f;
			}
			HKHBBBFLGJH().SetFloat("_TimeX", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("_Value7", Value);
			NBMPPNFKFLB().SetFloat("_Blue_R", Value2);
			MMOODGIODPC().SetFloat("_BlurVector", Intensity);
			HKHBBBFLGJH().SetFloat("--------------------------------", CCIENBFIKKH);
			GCDFNHMJMIP().SetVector("Error: I/O Failure! :(", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1439f, 333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("violet");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find(" beatThreshold: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 474f)
			{
				HBJJOCHGOPH = 85f;
			}
			MMOODGIODPC().SetFloat("_Speed", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("settings.hitvariation", Value);
			HCGJCMDJPGD().SetFloat("_TimeX", Value2);
			FHFLKLMFHOI().SetFloat("_ScreenResolution", Intensity);
			FHFLKLMFHOI().SetFloat("[PlayerBase] Starting game from: ", CCIENBFIKKH);
			JLHLHKPHDFO().SetVector("No Dispatcher exists in the scene. Actions will not be invoked!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1055f, 1975f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 612f)
			{
				HBJJOCHGOPH = 118f;
			}
			FHFLKLMFHOI().SetFloat("/", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("menuthemes", Value);
			NBPKMLMCHFN.SetFloat("true", Value2);
			FHFLKLMFHOI().SetFloat("LT", Intensity);
			MMOODGIODPC().SetFloat("_TimeX", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("[PlayerBase] Got checkpoint at ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 952f, 1197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 356f)
			{
				HBJJOCHGOPH = 116f;
			}
			GCDFNHMJMIP().SetFloat("Sent count: ", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("_BlurSize", Value);
			GKILCDHJFEG().SetFloat("Loading inventory", Value2);
			HCGJCMDJPGD().SetFloat("_BlurRadius", Intensity);
			GKILCDHJFEG().SetFloat("menu.tabid", CCIENBFIKKH);
			IONHGBPGCHK().SetVector(". Client should be in a room. Current connectionStateDetailed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1768f, 1523f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("Uploading content...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
