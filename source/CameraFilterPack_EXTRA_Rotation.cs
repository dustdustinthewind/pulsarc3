// CameraFilterPack_EXTRA_Rotation
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/EXTRA/Rotation")]
public class CameraFilterPack_EXTRA_Rotation : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-360f, 360f)]
	public float Rotation;

	[Range(-1f, 2f)]
	public float PositionX = 0.5f;

	[Range(-1f, 2f)]
	public float PositionY = 0.5f;

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

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_Value");
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

	private void JBNPEHMDCMI()
	{
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 219f)
			{
				HBJJOCHGOPH = 1980f;
			}
			GKILCDHJFEG().SetFloat("#", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_NeutralTonemapperParams1", 0f - Rotation);
			CFEDGDGBCHE().SetFloat("string", PositionX);
			DNLMFEGJJDD().SetFloat("0", PositionY);
			DOHGBNPMBKG().SetFloat("Can't SendMove. Turn is finished by this player.", CCIENBFIKKH);
			GKILCDHJFEG().SetVector("_DistAmount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 778f, 977f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 115f)
			{
				HBJJOCHGOPH = 1200f;
			}
			DOHGBNPMBKG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat(".GoalProgress", 0f - Rotation);
			CFEDGDGBCHE().SetFloat("_Value", PositionX);
			DOHGBNPMBKG().SetFloat("SUBMIT", PositionY);
			DNLMFEGJJDD().SetFloat("Editor/", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("_Glow", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1703f, 1016f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("_BlurArea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1096f)
			{
				HBJJOCHGOPH = 1395f;
			}
			PLBEJJIHFPB().SetFloat(".icon", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_BlurCoe", 0f - Rotation);
			CFEDGDGBCHE().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", PositionX);
			CFEDGDGBCHE().SetFloat("StartButton", PositionY);
			KBOPGONOCNP().SetFloat("_ScreenResolution", CCIENBFIKKH);
			CFEDGDGBCHE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1606f, 658f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 437f)
			{
				HBJJOCHGOPH = 151f;
			}
			KBOPGONOCNP().SetFloat("Up ", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("/icon", 0f - Rotation);
			PLBEJJIHFPB().SetFloat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", PositionX);
			GKILCDHJFEG().SetFloat("MenuScene", PositionY);
			PDEAHJPOMEF().SetFloat("set", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("FPSToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1459f, 5f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void NEKCPLGFOFD()
	{
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/EXTRA_Rotation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Blend");
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
			NBPKMLMCHFN.SetFloat("_Value", 0f - Rotation);
			NBPKMLMCHFN.SetFloat("_Value2", PositionX);
			NBPKMLMCHFN.SetFloat("_Value3", PositionY);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 473f)
			{
				HBJJOCHGOPH = 496f;
			}
			NBPKMLMCHFN.SetFloat("yes", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("[Up]", 0f - Rotation);
			NBMPPNFKFLB().SetFloat("UI/Particles/Hidden", PositionX);
			NBPKMLMCHFN.SetFloat("f", PositionY);
			NBPKMLMCHFN.SetFloat("_TimeX", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 415f, 633f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			if (HBJJOCHGOPH > 687f)
			{
				HBJJOCHGOPH = 653f;
			}
			GKILCDHJFEG().SetFloat("L1", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_Bullet_4", 0f - Rotation);
			GKILCDHJFEG().SetFloat(" ", PositionX);
			DOHGBNPMBKG().SetFloat("_DiffuseColor", PositionY);
			CFEDGDGBCHE().SetFloat("Down", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("float,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1269f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_OffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_Quality");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void Update()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 120f)
			{
				HBJJOCHGOPH = 1930f;
			}
			DOHGBNPMBKG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Protocol switch from: ", 0f - Rotation);
			GKILCDHJFEG().SetFloat("z", PositionX);
			GKILCDHJFEG().SetFloat("maps.", PositionY);
			DNLMFEGJJDD().SetFloat("Jazz", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("OnStatusChanged: {0} current State: {1}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 997f, 1941f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find(".r");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("inventory.selected.");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
