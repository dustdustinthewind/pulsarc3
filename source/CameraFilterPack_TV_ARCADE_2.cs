// CameraFilterPack_TV_ARCADE_2
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/ARCADE_2")]
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
			NBPKMLMCHFN.SetFloat("ViewID {0} {1}{2}", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_Value3", Interferance_Size);
			PLBEJJIHFPB().SetFloat("_MatrixSpeed", Interferance_Speed);
			IGKFMCPDNOI().SetFloat("float,10", Contrast);
			MICHFGAOPKM().SetFloat("LevelProgressBar", Fade);
			PLBEJJIHFPB().SetVector("settings.enablehitsoundsinnormal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1872f, 1355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			PLBEJJIHFPB().SetFloat("inventory.selected.", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("Failed to Destroy objects of playerId: ", Interferance_Size);
			EPCGJFCCAFH().SetFloat("???", Interferance_Speed);
			NFMGLIKNOOC().SetFloat("[NetworkManager] Found ", Contrast);
			NBPKMLMCHFN.SetFloat("_EmissionGain", Fade);
			HCGJCMDJPGD().SetVector("-1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 807f, 1385f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			HCGJCMDJPGD().SetFloat(".b", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_ScreenResolution", Interferance_Size);
			MICHFGAOPKM().SetFloat("EventMenu", Interferance_Speed);
			PDEAHJPOMEF().SetFloat("Items/", Contrast);
			MICHFGAOPKM().SetFloat("Fill", Fade);
			EPCGJFCCAFH().SetVector(" : ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 254f, 1329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
		SCShader = Shader.Find("maps.");
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
		SCShader = Shader.Find("#random #epic #item");
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
			KBOPGONOCNP().SetFloat("settings.cameramovements", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("mapselector.filter.favoriteonly", Interferance_Size);
			PDEAHJPOMEF().SetFloat("_BaseTex", Interferance_Speed);
			DOHGBNPMBKG().SetFloat("_Green_B", Contrast);
			NFMGLIKNOOC().SetFloat("_Blue_G", Fade);
			IGKFMCPDNOI().SetVector("_ExposureAdjustment", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 440f, 1244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			KBOPGONOCNP().SetFloat("Turn", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_TimeX", Interferance_Size);
			NFMGLIKNOOC().SetFloat("_Value3", Interferance_Speed);
			MICHFGAOPKM().SetFloat("_BlurRadius4", Contrast);
			HCGJCMDJPGD().SetFloat("#no", Fade);
			PDEAHJPOMEF().SetVector("_BlurParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 582f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Noise_TV", Interferance_Size);
			NBPKMLMCHFN.SetFloat("_Value2", Interferance_Speed);
			DOHGBNPMBKG().SetFloat("Joystick1Button4", Contrast);
			HCGJCMDJPGD().SetFloat("_TargetScale", Fade);
			EPCGJFCCAFH().SetVector("[Singleton] An instance of '", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1481f, 9f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			HCGJCMDJPGD().SetFloat("_Value7", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("CameraFilterPack/EyesVision_1", Interferance_Size);
			NBPKMLMCHFN.SetFloat("_FadeFX", Interferance_Speed);
			MICHFGAOPKM().SetFloat("menu.selectedlevelid", Contrast);
			MICHFGAOPKM().SetFloat("unsubscribemap", Fade);
			PDEAHJPOMEF().SetVector("Error! no audio sources attached to AudioSampler.css", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 369f, 1015f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("1234332714");
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
		SCShader = Shader.Find("_ProjInfo");
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
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Intensity", Interferance_Size);
			NFMGLIKNOOC().SetFloat("%", Interferance_Speed);
			HCGJCMDJPGD().SetFloat("_SpawnHeuristic", Contrast);
			NBPKMLMCHFN.SetFloat("t", Fade);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Distortion_Flush", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 272f, 869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			HCGJCMDJPGD().SetFloat("_Value", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("Please attach component to a Graphical UI component", Interferance_Size);
			KBOPGONOCNP().SetFloat("2hands", Interferance_Speed);
			KBOPGONOCNP().SetFloat("Prints the number of logs currently held by DebugLogs", Contrast);
			NFMGLIKNOOC().SetFloat("Load Game", Fade);
			DOHGBNPMBKG().SetVector("plogs", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1748f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
