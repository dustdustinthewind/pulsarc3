// CameraFilterPack_VHS_Tracking
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/VHS/Tracking")]
public class CameraFilterPack_VHS_Tracking : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 2f)]
	public float Tracking = 1f;

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

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 642f)
			{
				HBJJOCHGOPH = 13f;
			}
			KAFBNOBOIAJ().SetFloat("_Value5", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("DifficultyBG", Tracking);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 18f, 449f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 498f)
			{
				HBJJOCHGOPH = 666f;
			}
			NBPKMLMCHFN.SetFloat("challenges.", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_ToPrevViewProjCombined", Tracking);
			NBPKMLMCHFN.SetVector("LivesSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 690f, 1050f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 261f)
			{
				HBJJOCHGOPH = 1486f;
			}
			ADGHJOHKEHG().SetFloat("_Blue_B", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", Tracking);
			DOHGBNPMBKG().SetVector(".jpg", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 476f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("D-Pad Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetFloat("_Value", Tracking);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("[MapEditor] Loading events...");
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

	private void Update()
	{
	}

	private void LLJLDLLNFBH()
	{
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OEENOOGEEHD()
	{
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 496f)
			{
				HBJJOCHGOPH = 1366f;
			}
			LPMLLJKMAMP().SetFloat("SupportLogger OnFailedToConnectToPhoton(", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Tracking);
			FHFLKLMFHOI().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 192f, 1015f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("_ChangeRed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_VividLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1354f)
			{
				HBJJOCHGOPH = 1212f;
			}
			KEMAALEODNH().SetFloat("[PlayerBase] Game mode: ", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("IEnumerable", Tracking);
			LDNADDJMIPK().SetVector("LeaderboardsButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1314f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1650f)
			{
				HBJJOCHGOPH = 1345f;
			}
			DEFBJOCJJKF().SetFloat("Encryption wasn't established: ", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat(") then the masterserver requests a disconnect!", Tracking);
			KEMAALEODNH().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 810f, 694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 458f)
			{
				HBJJOCHGOPH = 1326f;
			}
			LPMLLJKMAMP().SetFloat("_PrevViewProj", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Intensity", Tracking);
			NBPKMLMCHFN.SetVector("#random #epic #item", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 969f, 200f));
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

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BGDONBMDPGM()
	{
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1776f)
			{
				HBJJOCHGOPH = 1412f;
			}
			LDNADDJMIPK().SetFloat("Move environment object to the position", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_GrainOffsetScale", Tracking);
			LPMLLJKMAMP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1661f, 664f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("#no");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 503f)
			{
				HBJJOCHGOPH = 1784f;
			}
			LPMLLJKMAMP().SetFloat("-1", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_MainTex", Tracking);
			LDNADDJMIPK().SetVector("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1050f, 756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1557f)
			{
				HBJJOCHGOPH = 600f;
			}
			DOHGBNPMBKG().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_PositionY", Tracking);
			GHHPOGODBHB().SetVector("[PlayerBase] Delete checkpoint data", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1709f, 577f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("Particles/Additive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1028f)
			{
				HBJJOCHGOPH = 1740f;
			}
			GHHPOGODBHB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/Drawing_Manga_Flash_Color", Tracking);
			DOHGBNPMBKG().SetVector("settings.shaders.bloomintencity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 536f, 992f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_FarCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1656f)
			{
				HBJJOCHGOPH = 1333f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack_TV_Vignetting1", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("0.00", Tracking);
			LDNADDJMIPK().SetVector("\" gets executed locally only, if at all.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1090f, 1826f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("y");
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
			if (HBJJOCHGOPH > 1837f)
			{
				HBJJOCHGOPH = 317f;
			}
			LDNADDJMIPK().SetFloat("[Down]", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("#highscore", Tracking);
			ADGHJOHKEHG().SetVector("CameraFilterPack/Blend2Camera_ColorBurn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 877f, 574f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 486f)
			{
				HBJJOCHGOPH = 1742f;
			}
			KEMAALEODNH().SetFloat("). ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_MainTex2", Tracking);
			NBPKMLMCHFN.SetVector("mapselector.filter.favoriteonly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 932f, 47f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1460f)
			{
				HBJJOCHGOPH = 1195f;
			}
			FHFLKLMFHOI().SetFloat("_Luminance", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("#TBD", Tracking);
			KEMAALEODNH().SetVector("_FarCamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1142f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_SampleScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1387f)
			{
				HBJJOCHGOPH = 1635f;
			}
			KEMAALEODNH().SetFloat("[MapEditor] Importing map: ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("InstantiateRpc", Tracking);
			GHHPOGODBHB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1325f, 659f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1788f)
			{
				HBJJOCHGOPH = 776f;
			}
			KEMAALEODNH().SetFloat("SetSatelliteTrailWidth", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("0.00", Tracking);
			LDNADDJMIPK().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1843f, 339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
			if (HBJJOCHGOPH > 1360f)
			{
				HBJJOCHGOPH = 664f;
			}
			LDNADDJMIPK().SetFloat("[LevelEditorScene] Item creation successful! Published Item ID: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Set Satellite Radius", Tracking);
			DOHGBNPMBKG().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1632f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/VHS_Tracking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
