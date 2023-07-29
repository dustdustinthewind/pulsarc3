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
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value4", Value);
			GKILCDHJFEG().SetFloat(" not exist", Value2);
			GCDFNHMJMIP().SetFloat("_Value6", Intensity);
			MFHPKGICPIO().SetFloat("GameVolumeSlider", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("PointerEnter ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1626f, 976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			KAFBNOBOIAJ().SetFloat("Set particles start speed", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Most likely the game became empty during the switch to GameServer.", Value);
			FHFLKLMFHOI().SetFloat("_MainTex2", Value2);
			GCDFNHMJMIP().SetFloat("GameScene", Intensity);
			GCDFNHMJMIP().SetFloat("#close", CCIENBFIKKH);
			EOCCJGIGEGJ().SetVector("_Speed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1050f, 1641f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			GCDFNHMJMIP().SetFloat(".lastCheckpoint.lives", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("mapselector.filter.subscribedonly", Value);
			GKILCDHJFEG().SetFloat("_Value3", Value2);
			GCDFNHMJMIP().SetFloat("_ScreenResolution", Intensity);
			MMOODGIODPC().SetFloat("_ScreenResolution", CCIENBFIKKH);
			JLHLHKPHDFO().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 408f, 881f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			HCGJCMDJPGD().SetFloat("UseScanLine", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("Horizontal", Value);
			KBOPGONOCNP().SetFloat("_SpherePositionY", Value2);
			JLHLHKPHDFO().SetFloat("/", Intensity);
			FHFLKLMFHOI().SetFloat("#getrewardfailed: ", CCIENBFIKKH);
			NBMPPNFKFLB().SetVector("_DistanceParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1508f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("]");
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
			KAFBNOBOIAJ().SetFloat(" Message: ", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("inventory.itemscash", Value);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", Value2);
			GCDFNHMJMIP().SetFloat("menu.playedsolo", Intensity);
			NBPKMLMCHFN.SetFloat("_History1LumaTex", CCIENBFIKKH);
			MMOODGIODPC().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 468f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		SCShader = Shader.Find("_Bullet_1");
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
			MFHPKGICPIO().SetFloat("[PlayerBase] Reset", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("0.00", Value);
			GKILCDHJFEG().SetFloat("_MainTex", Value2);
			KAFBNOBOIAJ().SetFloat(". The group number should be at least 1.", Intensity);
			NBMPPNFKFLB().SetFloat("_Color", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("mapselector.filter.subscribedonly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 694f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("/");
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
		SCShader = Shader.Find("Vertical");
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
			KAFBNOBOIAJ().SetFloat("/?player=", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Players NetIDs:", Value);
			IONHGBPGCHK().SetFloat("menu.tabid", Value2);
			NBMPPNFKFLB().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", Intensity);
			KAFBNOBOIAJ().SetFloat("_Red_C", CCIENBFIKKH);
			MMOODGIODPC().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1860f, 1065f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		SCShader = Shader.Find("LevelInfoInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("value");
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_Value7", Value);
			JLHLHKPHDFO().SetFloat("_Blue_G", Value2);
			FHFLKLMFHOI().SetFloat("_OcclusionTexture", Intensity);
			MFHPKGICPIO().SetFloat("-", CCIENBFIKKH);
			HKHBBBFLGJH().SetVector("Error: You're not logged into Steam!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1439f, 333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
		SCShader = Shader.Find("red");
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
			JLHLHKPHDFO().SetFloat("_Speed", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("]", Value);
			KBOPGONOCNP().SetFloat("_TimeX", Value2);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Intensity);
			IONHGBPGCHK().SetFloat("SpawnObj", CCIENBFIKKH);
			HKHBBBFLGJH().SetVector("\n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1055f, 1975f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			HCGJCMDJPGD().SetFloat("MenuScene", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("Image", Value);
			NBPKMLMCHFN.SetFloat(".completedMaps", Value2);
			KBOPGONOCNP().SetFloat("RT", Intensity);
			KAFBNOBOIAJ().SetFloat("_Noise", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("[PlayerBase] ShowImage \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 952f, 1197f));
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
			EOCCJGIGEGJ().SetFloat("PickupItemInit", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Bloom1", Value);
			JLHLHKPHDFO().SetFloat("LoadingStatusText", Value2);
			KAFBNOBOIAJ().SetFloat("_Offsets", Intensity);
			KAFBNOBOIAJ().SetFloat("menu.tabid", CCIENBFIKKH);
			JLHLHKPHDFO().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1768f, 1523f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("Item invalid. Make sure your mod contains at leats one file.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
