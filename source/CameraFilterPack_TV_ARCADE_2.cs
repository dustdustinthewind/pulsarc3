// CameraFilterPack_TV_ARCADE_2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/ARCADE_2")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_ARCADE_2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 10f)]
	public float Interferance_Size = 1f;

	[Range(0f, 10f)]
	public float Interferance_Speed = 0.5f;

	[Range(0f, 10f)]
	public float Contrast = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	private void FOMNCPKKCFN()
	{
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 60f)
			{
				HBJJOCHGOPH = 773f;
			}
			MICHFGAOPKM().SetFloat(" respawn: ", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Value2", Interferance_Size);
			NDMPCDHADMJ().SetFloat("_MatrixSpeed", Interferance_Speed);
			MICHFGAOPKM().SetFloat("Lerp speed. Recomended 10", Contrast);
			EPCGJFCCAFH().SetFloat("sprite", Fade);
			HCGJCMDJPGD().SetVector("cameramovements:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1872f, 1355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1134f)
			{
				HBJJOCHGOPH = 1929f;
			}
			KBOPGONOCNP().SetFloat("inventory.selected.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("]. Please verify you have this gameobject in a Resources folder.", Interferance_Size);
			PLBEJJIHFPB().SetFloat("???", Interferance_Speed);
			EPCGJFCCAFH().SetFloat("[NetworkManager] Found ", Contrast);
			KBOPGONOCNP().SetFloat("_EmissionGain", Fade);
			HCGJCMDJPGD().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 807f, 1385f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1227f)
			{
				HBJJOCHGOPH = 588f;
			}
			KBOPGONOCNP().SetFloat(".b", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", Interferance_Size);
			NBPKMLMCHFN.SetFloat("HelpMenu", Interferance_Speed);
			NBPKMLMCHFN.SetFloat("Items/", Contrast);
			DOHGBNPMBKG().SetFloat("Fill", Fade);
			NDMPCDHADMJ().SetVector("Result for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 254f, 1329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NKLIHNJCHOG()
	{
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("[MapsData] Preloading workshop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BGFJOEPFOPM()
	{
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("#random #common #item");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1959f)
			{
				HBJJOCHGOPH = 1688f;
			}
			KBOPGONOCNP().SetFloat("menu.selectedplaymode", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("mapselector.filter.favoriteonly", Interferance_Size);
			IGKFMCPDNOI().SetFloat("_Intensity", Interferance_Speed);
			PDEAHJPOMEF().SetFloat("_Green_G", Contrast);
			NFMGLIKNOOC().SetFloat("_Blue_R", Fade);
			DOHGBNPMBKG().SetVector("_Curve", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 440f, 1244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("\n\n#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1516f)
			{
				HBJJOCHGOPH = 1504f;
			}
			PLBEJJIHFPB().SetFloat("turn", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Distortion_Half_Sphere", Interferance_Size);
			NBPKMLMCHFN.SetFloat("_Value2", Interferance_Speed);
			NFMGLIKNOOC().SetFloat("_SunPosition", Contrast);
			NFMGLIKNOOC().SetFloat("{0}", Fade);
			DOHGBNPMBKG().SetVector("_SpawnHeuristic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 582f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_ARCADE_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1515f)
			{
				HBJJOCHGOPH = 1004f;
			}
			DOHGBNPMBKG().SetFloat("CameraFilterPack/AAA_Super_Hexagon", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("CameraFilterPack_TV_Noise", Interferance_Size);
			PDEAHJPOMEF().SetFloat("_Value2", Interferance_Speed);
			NFMGLIKNOOC().SetFloat("Joystick1Button3", Contrast);
			KBOPGONOCNP().SetFloat("_Radius", Fade);
			NFMGLIKNOOC().SetVector("[Singleton] Using instance of '", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1481f, 9f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("duration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 819f)
			{
				HBJJOCHGOPH = 1355f;
			}
			EPCGJFCCAFH().SetFloat("_Value7", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/EyesVision_1", Interferance_Size);
			IGKFMCPDNOI().SetFloat("_Blue_C", Interferance_Speed);
			DOHGBNPMBKG().SetFloat("offline", Contrast);
			NBPKMLMCHFN.SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Fade);
			EPCGJFCCAFH().SetVector("Error! no audio sources attached to AudioSampler.css", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 369f, 1015f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("907198288");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_ScreenSize");
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
			if (HBJJOCHGOPH > 1212f)
			{
				HBJJOCHGOPH = 234f;
			}
			NDMPCDHADMJ().SetFloat("_Value4", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_MainTex", Interferance_Size);
			KBOPGONOCNP().SetFloat(" ", Interferance_Speed);
			MICHFGAOPKM().SetFloat("_Offsets", Contrast);
			NDMPCDHADMJ().SetFloat("Please specify either t or f.", Fade);
			NFMGLIKNOOC().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 272f, 869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	private void MMBPLGGLPDB()
	{
	}

	private void OBAEDJJDCPN()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1278f)
			{
				HBJJOCHGOPH = 1890f;
			}
			HCGJCMDJPGD().SetFloat("_TimeX", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Default UI Material", Interferance_Size);
			IGKFMCPDNOI().SetFloat(":", Interferance_Speed);
			PLBEJJIHFPB().SetFloat("Prints list of all previous commands", Contrast);
			NDMPCDHADMJ().SetFloat("Exit to Windows", Fade);
			NFMGLIKNOOC().SetVector("quit", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1748f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void CFIAKIJAILI()
	{
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	private void GPFJMKCGHGB()
	{
	}
}
