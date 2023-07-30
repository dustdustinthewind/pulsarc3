// CameraFilterPack_Blizzard
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Blizzard")]
public class CameraFilterPack_Blizzard : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 2f)]
	public float _Speed = 1f;

	[Range(0.2f, 2f)]
	public float _Size = 1f;

	[Range(0f, 1f)]
	public float _Fade = 1f;

	private Material BJFKDHHMLJH;

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

	private void KMKLDAJLCNM()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1247f)
			{
				HBJJOCHGOPH = 1940f;
			}
			LNLKMDPHDCC().SetFloat("_Axis", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Vertical", _Speed);
			PGPEMMBJOOG().SetFloat("Avoid using this directly. Thanks.", _Size);
			NFMGLIKNOOC().SetFloat("_Value", _Fade);
			LNLKMDPHDCC().SetTexture("JoinButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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

	private void DNENFLNCIJP()
	{
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load(".") as Texture2D;
		SCShader = Shader.Find("1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void NBGIMIDICKE()
	{
		FPHEBLMINDA = Resources.Load(",") as Texture2D;
		SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1668f)
			{
				HBJJOCHGOPH = 1295f;
			}
			LNLKMDPHDCC().SetFloat("OnAwakeRPC", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("menu.enableselectormusic", _Speed);
			PGPEMMBJOOG().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", _Size);
			NFMGLIKNOOC().SetFloat("Set Sun Colors", _Fade);
			NBPKMLMCHFN.SetTexture("\"", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			NBPKMLMCHFN.SetFloat("_Value", _Speed);
			NBPKMLMCHFN.SetFloat("_Value2", _Size);
			NBPKMLMCHFN.SetFloat("_Value3", _Fade);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 556f)
			{
				HBJJOCHGOPH = 206f;
			}
			LNLKMDPHDCC().SetFloat("_TimeX", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Near", _Speed);
			NFMGLIKNOOC().SetFloat(",", _Size);
			LNLKMDPHDCC().SetFloat("SetBGColor", _Fade);
			IGIAPKPKGPK().SetTexture("JoystickButton13", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void FHGKIOOMMOH()
	{
		FPHEBLMINDA = Resources.Load("restrictions\n\n#until: ") as Texture2D;
		SCShader = Shader.Find("BlockCount");
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1690f)
			{
				HBJJOCHGOPH = 62f;
			}
			KGOLDDBHIFN().SetFloat("SingleplayerButton", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_FarCorner", _Speed);
			IGIAPKPKGPK().SetFloat("AvatarImage", _Size);
			LNLKMDPHDCC().SetFloat("_Value7", _Fade);
			PDEAHJPOMEF().SetTexture("plainText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("menu.hardcoreinfo") as Texture2D;
		SCShader = Shader.Find("IntraSig");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 422f)
			{
				HBJJOCHGOPH = 658f;
			}
			NFMGLIKNOOC().SetFloat("_Green_R", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("Lightning", _Speed);
			GKILCDHJFEG().SetFloat("_Distance", _Size);
			ACHNOHCLGOO().SetFloat("menu.tabid", _Fade);
			NBPKMLMCHFN.SetTexture("_BlurCoe", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return BJFKDHHMLJH;
	}

	private void MMBPLGGLPDB()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("mapselector.filter.favoriteonly") as Texture2D;
		SCShader = Shader.Find("/files/editor_manual.pdf");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 20f)
			{
				HBJJOCHGOPH = 262f;
			}
			FHFLKLMFHOI().SetFloat("Items/", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_SecondTex", _Speed);
			KGOLDDBHIFN().SetFloat("#no", _Size);
			PGPEMMBJOOG().SetFloat("[Up-Right]", _Fade);
			ACHNOHCLGOO().SetTexture("settings.enablehitsoundsinrelax", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 386f)
			{
				HBJJOCHGOPH = 1402f;
			}
			PGPEMMBJOOG().SetFloat("OnPickedUp", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("ZoomSpeed", _Speed);
			FHFLKLMFHOI().SetFloat("_DiffuseColor", _Size);
			LONNIJMNKFB().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", _Fade);
			NFMGLIKNOOC().SetTexture("Needs to be attached to the Event System component in the scene", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("f") as Texture2D;
		SCShader = Shader.Find("saveGameName ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 173f)
			{
				HBJJOCHGOPH = 400f;
			}
			NBPKMLMCHFN.SetFloat("_MatrixSize", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("13", _Speed);
			LONNIJMNKFB().SetFloat("a", _Size);
			ACHNOHCLGOO().SetFloat("Lerp speed. Recomended 10", _Fade);
			GKILCDHJFEG().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void DHNGNHGDPLM()
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
			if (HBJJOCHGOPH > 349f)
			{
				HBJJOCHGOPH = 1119f;
			}
			FHFLKLMFHOI().SetFloat("Editor", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("ViewMenu", _Speed);
			ACHNOHCLGOO().SetFloat("PublishButton", _Size);
			LNLKMDPHDCC().SetFloat("Right Stick Click", _Fade);
			GKILCDHJFEG().SetTexture("ArcsDestroyDelaySlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Blizzard1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blizzard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1346f)
			{
				HBJJOCHGOPH = 1872f;
			}
			NFMGLIKNOOC().SetFloat("_Value", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("Hidden/TonemappingColorGrading", _Speed);
			LNLKMDPHDCC().SetFloat("SetSatelliteRadius", _Size);
			IGIAPKPKGPK().SetFloat("_TimeX", _Fade);
			GKILCDHJFEG().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("player.gamecompleted") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
