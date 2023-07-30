// CameraFilterPack_Blend2Camera_Multiply
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Multiply")]
public class CameraFilterPack_Blend2Camera_Multiply : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Multiply";

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

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 580f)
			{
				HBJJOCHGOPH = 874f;
			}
			if (Camera2 != null)
			{
				LDNADDJMIPK().SetTexture("maps.", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("ShowTitle", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_DotSize", BlendFX);
			NDMPCDHADMJ().SetFloat("maps.", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1674f, 143f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MEMKLOMFFJO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MGMLGCNLMKN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void FKEJGBFDCAH()
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

	private void NPLCENPNJBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 640f)
			{
				HBJJOCHGOPH = 180f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture("start", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("_Value3", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat(" ", BlendFX);
			NBPKMLMCHFN.SetFloat("id", SwitchCameraToCamera2);
			NDMPCDHADMJ().SetVector("_BokehParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 600f, 1906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1090f)
			{
				HBJJOCHGOPH = 1128f;
			}
			if (Camera2 != null)
			{
				DNLMFEGJJDD().SetTexture("_Value", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("fade in duration", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("SupportLogger ", BlendFX);
			NDMPCDHADMJ().SetFloat("[PlayerBase] SetBGColor error: ", SwitchCameraToCamera2);
			DNLMFEGJJDD().SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 186f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
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

	private void NKLIHNJCHOG()
	{
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JCDPMLPNOOC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -60);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FNCDAPDOBBI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFJDKDFLGBG()
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

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 433f)
			{
				HBJJOCHGOPH = 769f;
			}
			if (Camera2 != null)
			{
				HCGJCMDJPGD().SetTexture("_SoftZDistance", JDMCFBKJHDD);
			}
			DONENAMLFLF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("}", BlendFX);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_BlackHole", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1328f, 510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CACAAKGCPPL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KHDANGFKIGL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JHBPINEKDPE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -11);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void DBEMDAJDDDA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DIPDEHOOBPG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 81);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			if (HBJJOCHGOPH > 444f)
			{
				HBJJOCHGOPH = 673f;
			}
			if (Camera2 != null)
			{
				HKGAONMOBMH().SetTexture("_Value2", JDMCFBKJHDD);
			}
			PDEAHJPOMEF().SetFloat("steamid", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("clear", BlendFX);
			FEAEGGCNIAA().SetFloat(" on effect ", SwitchCameraToCamera2);
			MICHFGAOPKM().SetVector("CameraFilterPack/Blend2Camera_Saturation", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1587f, 177f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MOMGJJDIFFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MKIMDFLBFOM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -119);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNFMIAFHMJM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 124);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1113f)
			{
				HBJJOCHGOPH = 1060f;
			}
			if (Camera2 != null)
			{
				NDMPCDHADMJ().SetTexture("SaveButton", JDMCFBKJHDD);
			}
			DONENAMLFLF().SetFloat("start", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value3", BlendFX);
			NDMPCDHADMJ().SetFloat("Done!", SwitchCameraToCamera2);
			JFDGLLEOPGB().SetVector("mapselector.orderby", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 841f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AENIGCONKBD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NAALCEPIHCH()
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

	private void IBEAPBDAOCC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 920f)
			{
				HBJJOCHGOPH = 531f;
			}
			if (Camera2 != null)
			{
				JFDGLLEOPGB().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			DONENAMLFLF().SetFloat("CameraFilterPack/Vision_Rainbow", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat(".GoalProgress", BlendFX);
			PDEAHJPOMEF().SetFloat("ok", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("Editor/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1194f, 239f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1219f)
			{
				HBJJOCHGOPH = 204f;
			}
			if (Camera2 != null)
			{
				JFDGLLEOPGB().SetTexture("InfoCanvas", JDMCFBKJHDD);
			}
			DNLMFEGJJDD().SetFloat("ChatHistoryInputField", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", BlendFX);
			PDEAHJPOMEF().SetFloat(" is muted", SwitchCameraToCamera2);
			JFDGLLEOPGB().SetVector("CameraFilterPack/3D_Computer", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 994f, 631f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OHFOLGANOLC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -94);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LICOLMAOHKI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1920f)
			{
				HBJJOCHGOPH = 1382f;
			}
			if (Camera2 != null)
			{
				PDEAHJPOMEF().SetTexture("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("</color>", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("DifficultyBG", BlendFX);
			NDMPCDHADMJ().SetFloat("{0,-18} {1,18}", SwitchCameraToCamera2);
			DONENAMLFLF().SetVector("Can't SendMove. Turn is finished by this player.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 849f, 491f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 636f)
			{
				HBJJOCHGOPH = 960f;
			}
			if (Camera2 != null)
			{
				OCHJIMJNEMO().SetTexture("CameraFilterPack/TV_Vignetting", JDMCFBKJHDD);
			}
			DNLMFEGJJDD().SetFloat(" is muted", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("Reset All", BlendFX);
			DNLMFEGJJDD().SetFloat("/", SwitchCameraToCamera2);
			HCGJCMDJPGD().SetVector("#mapby", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1332f, 1318f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJAJBMGGPFB()
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

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1828f)
			{
				HBJJOCHGOPH = 347f;
			}
			if (Camera2 != null)
			{
				FEAEGGCNIAA().SetTexture("/music", JDMCFBKJHDD);
			}
			PDEAHJPOMEF().SetFloat("_ScratchTex", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("[ImageLoader] Loaded image from ", BlendFX);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Blend2Camera_Multiply", SwitchCameraToCamera2);
			CFEDGDGBCHE().SetVector("Updated!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 705f, 1415f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void EAOKCECGKAK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 87);
			Camera2.targetTexture = JDMCFBKJHDD;
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

	private void OEENOOGEEHD()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 14f)
			{
				HBJJOCHGOPH = 1658f;
			}
			if (Camera2 != null)
			{
				DNLMFEGJJDD().SetTexture("_Tint", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("OpCreateRoom()", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("#pleasewait", BlendFX);
			MICHFGAOPKM().SetFloat("#news", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1208f, 1870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCPEDDLAMIB()
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

	private void MMOKKAPFGAK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DOEPOGLEGLE()
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
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1505f)
			{
				HBJJOCHGOPH = 698f;
			}
			if (Camera2 != null)
			{
				OCHJIMJNEMO().SetTexture("menu.playedpage", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("_TimeX", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("SaveGameName is null or empty!", BlendFX);
			OCHJIMJNEMO().SetFloat("InfoCanvas", SwitchCameraToCamera2);
			NDMPCDHADMJ().SetVector("[ItemsHandler] Item not found:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 722f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOOGLMFBJHK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -82);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KNBJBNDGCIJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FGIOPGGPLMB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CMBGFMAOEPG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 30);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KLOLKEBAPFO()
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
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1158f)
			{
				HBJJOCHGOPH = 54f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("CameraFilterPack_AAA_Blood_Hit1", JDMCFBKJHDD);
			}
			NDMPCDHADMJ().SetFloat("inventory.itemscash", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("' ping: ", BlendFX);
			DONENAMLFLF().SetFloat("CameraFilterPack/Atmosphere_Rain", SwitchCameraToCamera2);
			CFEDGDGBCHE().SetVector("_Contrast", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 435f, 809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1282f)
			{
				HBJJOCHGOPH = 1282f;
			}
			if (Camera2 != null)
			{
				OCHJIMJNEMO().SetTexture("Joystick1Button5", JDMCFBKJHDD);
			}
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Blend2Camera_Color", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("Warning: Unhandled event ", BlendFX);
			FEAEGGCNIAA().SetFloat("/?player=", SwitchCameraToCamera2);
			DNLMFEGJJDD().SetVector("_BokehParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 486f, 1490f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BLDMINMDHPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void MMMDPANNAIO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 12);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1125f)
			{
				HBJJOCHGOPH = 1645f;
			}
			if (Camera2 != null)
			{
				FEAEGGCNIAA().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			PDEAHJPOMEF().SetFloat("B:", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("{0}{1}{2}={3}", BlendFX);
			PDEAHJPOMEF().SetFloat("float,10", SwitchCameraToCamera2);
			OCHJIMJNEMO().SetVector("Hidden/ScreenSpaceReflection", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 72f, 891f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
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

	private void AIJGAJIOJDJ()
	{
	}

	private void LADCJEIALMH()
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

	private void DNNFHBOOPIN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -99);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMEONPMCNJG()
	{
	}

	private void JJIMCJBMKEF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -26);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}
}
