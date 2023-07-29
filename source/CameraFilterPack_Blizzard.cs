// CameraFilterPack_Blizzard
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Weather/Blizzard")]
[ExecuteInEditMode]
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
			PDEAHJPOMEF().SetFloat("_RandomTexture", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat(" registered.", _Speed);
			NBPKMLMCHFN.SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", _Size);
			PDEAHJPOMEF().SetFloat("_Value", _Fade);
			FEAEGGCNIAA().SetTexture("JoinButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		FPHEBLMINDA = Resources.Load("Not sending leave operation. State is not 'Joined': ") as Texture2D;
		SCShader = Shader.Find("sprite");
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
		FPHEBLMINDA = Resources.Load("Submit") as Texture2D;
		SCShader = Shader.Find("_GrainTex");
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
			GKILCDHJFEG().SetFloat(" PhotonView: ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("HPToggle", _Speed);
			MMOODGIODPC().SetFloat("The other scroll rect doesnt support scrolling vertically", _Size);
			LONNIJMNKFB().SetFloat("Set Sun Colors", _Fade);
			LONNIJMNKFB().SetTexture("#failed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			ACHNOHCLGOO().SetFloat("_Value", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Near", _Speed);
			KGOLDDBHIFN().SetFloat(",", _Size);
			FEAEGGCNIAA().SetFloat("Set Background Color", _Fade);
			KGOLDDBHIFN().SetTexture("Trackpad", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
		SCShader = Shader.Find("[#clicktogetreward]");
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
			PDEAHJPOMEF().SetFloat("menu.enableselectormusic", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Params", _Speed);
			MMOODGIODPC().SetFloat("AvatarImage", _Size);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Blend2Camera_HardLight", _Fade);
			EFDEIFCDAFG().SetTexture("cipherText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
		FPHEBLMINDA = Resources.Load("menu.selectedplaymode") as Texture2D;
		SCShader = Shader.Find("request");
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
			FEAEGGCNIAA().SetFloat("_Green_G", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Visualize", _Speed);
			LNLKMDPHDCC().SetFloat("_Distance", _Size);
			GKILCDHJFEG().SetFloat("menu.tabid", _Fade);
			EFDEIFCDAFG().SetTexture("_SecondTex", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
		FPHEBLMINDA = Resources.Load("mapselector.filter.subscribedonly") as Texture2D;
		SCShader = Shader.Find("\nCreated by Oxy949");
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
			LNLKMDPHDCC().SetFloat("Items/", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_MainTex", _Speed);
			IGIAPKPKGPK().SetFloat("#mapalreadyexistupdate", _Size);
			GKILCDHJFEG().SetFloat("[Up-Right]", _Fade);
			LNLKMDPHDCC().SetTexture("[", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			ACHNOHCLGOO().SetFloat("PunRespawn with Position.", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_ScreenResolution", _Speed);
			PGPEMMBJOOG().SetFloat("_DiffuseColor", _Size);
			ACHNOHCLGOO().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", _Fade);
			EFDEIFCDAFG().SetTexture("Is it practically possible?", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		FPHEBLMINDA = Resources.Load("false") as Texture2D;
		SCShader = Shader.Find("OnDeserialize");
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
			LONNIJMNKFB().SetFloat("_MatrixSize", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("th", _Speed);
			LONNIJMNKFB().SetFloat("y", _Size);
			NFMGLIKNOOC().SetFloat("float,10", _Fade);
			FEAEGGCNIAA().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			EFDEIFCDAFG().SetFloat("MapConfig", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("SaveButton", _Speed);
			MMOODGIODPC().SetFloat("PublishButton", _Size);
			PDEAHJPOMEF().SetFloat("PS Home", _Fade);
			KGOLDDBHIFN().SetTexture("ArcsDestroyDelaySlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			LNLKMDPHDCC().SetFloat("_Value2", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_AdaptationSpeed", _Speed);
			GKILCDHJFEG().SetFloat("Set Satellite Radius", _Size);
			PDEAHJPOMEF().SetFloat("_Value", _Fade);
			MMOODGIODPC().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
