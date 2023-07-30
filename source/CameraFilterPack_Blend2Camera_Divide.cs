// CameraFilterPack_Blend2Camera_Divide
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Divide")]
public class CameraFilterPack_Blend2Camera_Divide : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Divide";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

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

	private void PDHKMDBNGGN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -74);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IHPLMLBJELK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CCKABCDEOJC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 19);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NAOLAJPDGIC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void KKGMKGHFELO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 73);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PCGODOELOHG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OEAMLMGNFFC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -97);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BOLBPPHJBMI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 802f)
			{
				HBJJOCHGOPH = 660f;
			}
			if (Camera2 != null)
			{
				LONNIJMNKFB().SetTexture("float,1.5", JDMCFBKJHDD);
			}
			LONNIJMNKFB().SetFloat("Spawn new environment object (sun, satellite etc) and sets its id", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("QuickSave", BlendFX);
			EJDPNJAEAKJ().SetFloat("PLEASE WAIT", SwitchCameraToCamera2);
			EJDPNJAEAKJ().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 751f, 993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDIJLKIIMLL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 930f)
			{
				HBJJOCHGOPH = 915f;
			}
			if (Camera2 != null)
			{
				EPCGJFCCAFH().SetTexture("value", JDMCFBKJHDD);
			}
			EJDPNJAEAKJ().SetFloat("settings_bindings_", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("SetSunSensitivity", BlendFX);
			NBPKMLMCHFN.SetFloat("PAUSE [SPACE]", SwitchCameraToCamera2);
			IGKFMCPDNOI().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 783f, 526f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
	}

	private void AENGMPAMCFL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -68);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1459f)
			{
				HBJJOCHGOPH = 1994f;
			}
			if (Camera2 != null)
			{
				EJDPNJAEAKJ().SetTexture("ItemNameText", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("CameraFilterPack/Distortion_Aspiration", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat(": ", BlendFX);
			IGKFMCPDNOI().SetFloat("-help", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("_Red_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 616f, 989f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ALMGMOOHLMA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CNDACAHCCOI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1830f)
			{
				HBJJOCHGOPH = 1121f;
			}
			if (Camera2 != null)
			{
				LONNIJMNKFB().SetTexture("[Up-Right-Left]", JDMCFBKJHDD);
			}
			EJDPNJAEAKJ().SetFloat("_MainTex2", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_VignetteCenter", BlendFX);
			KBOPGONOCNP().SetFloat("checkpoint", SwitchCameraToCamera2);
			IGKFMCPDNOI().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1413f, 809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GLGGNBOBFKE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -15);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DCGFEIBKOBB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1363f)
			{
				HBJJOCHGOPH = 378f;
			}
			if (Camera2 != null)
			{
				PLBEJJIHFPB().SetTexture("BitsData", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("BadgeText", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("Tab1Content", BlendFX);
			KBOPGONOCNP().SetFloat("No Name", SwitchCameraToCamera2);
			OGMEGHKECAH().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 889f, 1538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPJHPNGNEBP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 37);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GPNAOAKCMHC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIFPDKKBDHJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -99);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HJDPEBAPBPN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HOLDCFBBHHP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 115);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void HONBLGFDMLL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FNCDAPDOBBI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -33);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KCCIEMBMOBA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 61);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void EMAMCDFBGOA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 108);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KLILJHJNICK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 48);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBAPHFIBANG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 68);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EJJEDJIOFAB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FINDGJLEHOL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FCKIJIKNMCF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 120);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PPFGHAKKLMN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HHODKHPIBLG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -111);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBEAPBDAOCC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 35);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1591f)
			{
				HBJJOCHGOPH = 311f;
			}
			if (Camera2 != null)
			{
				KGOLDDBHIFN().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			EPCGJFCCAFH().SetFloat("finished", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("MouseY", BlendFX);
			NDMPCDHADMJ().SetFloat("&search=", SwitchCameraToCamera2);
			KBOPGONOCNP().SetVector("[LevelEditorScene] Print Audio Wave: Done", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 93f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OOBIMFILNED()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void DBIBFOINCKM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void COIJKMKIEAK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKIMDFLBFOM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -15);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void ANKALNDLHEL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1622f)
			{
				HBJJOCHGOPH = 819f;
			}
			if (Camera2 != null)
			{
				IGKFMCPDNOI().SetTexture("Gameplay/Base", JDMCFBKJHDD);
			}
			NDMPCDHADMJ().SetFloat("_BlurTexture", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_Visualize", BlendFX);
			NDMPCDHADMJ().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("settings.arcsdestroydelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 897f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
