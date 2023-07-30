// CameraFilterPack_EXTRA_Rotation
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/EXTRA/Rotation")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_TimeX");
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
			PDEAHJPOMEF().SetFloat(">", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_ToneCurveRange", 0f - Rotation);
			KBOPGONOCNP().SetFloat("bool", PositionX);
			DNLMFEGJJDD().SetFloat("0", PositionY);
			GKILCDHJFEG().SetFloat(". Not connectedAndReady.", CCIENBFIKKH);
			NBMPPNFKFLB().SetVector("UNDISTORT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 778f, 977f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			DOHGBNPMBKG().SetFloat("Fade", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat(".icon", 0f - Rotation);
			PLBEJJIHFPB().SetFloat("_Value", PositionX);
			CFEDGDGBCHE().SetFloat("Change Note:", PositionY);
			PDEAHJPOMEF().SetFloat("Editor/", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_Glow", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1703f, 1016f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		SCShader = Shader.Find("_ColorBuffer");
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
			GKILCDHJFEG().SetFloat("skin.", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_BlurCoe", 0f - Rotation);
			PLBEJJIHFPB().SetFloat("OnAwakeRPC", PositionX);
			DOHGBNPMBKG().SetFloat("[NetworkManager] Updating current room...", PositionY);
			DOHGBNPMBKG().SetFloat("_Value2", CCIENBFIKKH);
			NBMPPNFKFLB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1606f, 658f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			PLBEJJIHFPB().SetFloat("Up", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Editor", 0f - Rotation);
			NBMPPNFKFLB().SetFloat("null", PositionX);
			KBOPGONOCNP().SetFloat("reset", PositionY);
			KBOPGONOCNP().SetFloat("Command not found!", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("Scene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1459f, 5f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			PDEAHJPOMEF().SetFloat("GameScene", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("SpawnObj", 0f - Rotation);
			KBOPGONOCNP().SetFloat("_CutOff", PositionX);
			NBMPPNFKFLB().SetFloat("t", PositionY);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Retro_Loading", CCIENBFIKKH);
			PLBEJJIHFPB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 415f, 633f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			DNLMFEGJJDD().SetFloat("Triangle", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_Bullet_2", 0f - Rotation);
			DNLMFEGJJDD().SetFloat("(master)", PositionX);
			CFEDGDGBCHE().SetFloat("ready", PositionY);
			DNLMFEGJJDD().SetFloat("Down", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1269f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		SCShader = Shader.Find("_EdgeThreshold");
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
			PLBEJJIHFPB().SetFloat("_Value5", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", 0f - Rotation);
			NBPKMLMCHFN.SetFloat("z", PositionX);
			PDEAHJPOMEF().SetFloat("BadgeText", PositionY);
			CFEDGDGBCHE().SetFloat("Jazz", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 997f, 1941f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find(".a");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("MenuScene");
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
