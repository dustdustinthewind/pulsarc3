// CameraFilterPack_Distortion_Dream2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Dream2")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Dream2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float Distortion = 6f;

	[Range(0f, 32f)]
	public float Speed = 5f;

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

	private void LPMINJJPDCH()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 569f)
			{
				HBJJOCHGOPH = 1156f;
			}
			IGIAPKPKGPK().SetFloat("LoadingStatusText", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Map: ", Speed);
			HKGAONMOBMH().SetFloat("CameraFilterPack_eyes_vision_1", Distortion);
			LDNADDJMIPK().SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 220f, 694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 296f)
			{
				HBJJOCHGOPH = 1514f;
			}
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value3", Speed);
			HKHBBBFLGJH().SetFloat(" ", Distortion);
			LPMLLJKMAMP().SetVector("Received RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1702f, 885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LMADKINICIN()
	{
	}

	private void KFACDBHDAOD()
	{
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("sfxVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("PunRespawn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Dream2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("RPCs can only be sent in rooms. Call of \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 373f)
			{
				HBJJOCHGOPH = 1443f;
			}
			EOCCJGIGEGJ().SetFloat("speed", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("checkpoint", Speed);
			HKGAONMOBMH().SetFloat("_FgOverlap", Distortion);
			BLMPMOIDGMG().SetVector("Joystick1Button12", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 426f, 1830f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("#rt");
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("_Sat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("Items");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1498f)
			{
				HBJJOCHGOPH = 1311f;
			}
			OKJOKHGJHGF().SetFloat("SetCrosshairEmission", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("\n", Speed);
			KJMECMIGJJA().SetFloat("_MaxRadiusOrKInPaper", Distortion);
			OKJOKHGJHGF().SetVector("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1991f, 172f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void FABMDEHEDNO()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
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

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 323f)
			{
				HBJJOCHGOPH = 1653f;
			}
			KGOLDDBHIFN().SetFloat("float,0", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("player.xp", Speed);
			NBPKMLMCHFN.SetFloat("menu.playedsolo", Distortion);
			LDNADDJMIPK().SetVector("Lag ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 253f, 1133f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 962f)
			{
				HBJJOCHGOPH = 448f;
			}
			EOCCJGIGEGJ().SetFloat("Set Trail Zoom Speed", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("Set EnvSprite Color", Speed);
			NBPKMLMCHFN.SetFloat("float,1", Distortion);
			GJHLADDCMFF().SetVector("_FlipAlphaMask", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1054f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 195f)
			{
				HBJJOCHGOPH = 373f;
			}
			HKGAONMOBMH().SetFloat("_Green_B", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Object ID. Case-Sensitive", Speed);
			DNLMFEGJJDD().SetFloat("SfxVolumeSlider", Distortion);
			OGMEGHKECAH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 101f, 336f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1806f)
			{
				HBJJOCHGOPH = 701f;
			}
			KGOLDDBHIFN().SetFloat("_Value2", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("#ok", Speed);
			IGIAPKPKGPK().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", Distortion);
			GCDFNHMJMIP().SetVector("title", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 989f, 867f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void NKLIHNJCHOG()
	{
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 477f)
			{
				HBJJOCHGOPH = 1166f;
			}
			HEHKGPKLAKK().SetFloat("_MainTex2", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("Dec", Speed);
			NBPKMLMCHFN.SetFloat("Anomaly_With_Obj", Distortion);
			HEHKGPKLAKK().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1847f, 21f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1386f)
			{
				HBJJOCHGOPH = 1915f;
			}
			KGOLDDBHIFN().SetFloat("Tab2Content", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_Value4", Speed);
			DNLMFEGJJDD().SetFloat("ItemNameText", Distortion);
			EOCCJGIGEGJ().SetVector("GameScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1727f, 1134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void JOACBIEHHCE()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("arc");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1867f)
			{
				HBJJOCHGOPH = 986f;
			}
			EOCCJGIGEGJ().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Blur", Speed);
			KGOLDDBHIFN().SetFloat("RoomNameText", Distortion);
			HKHBBBFLGJH().SetVector("CameraFilterPack_TV_Arcade1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1910f, 1488f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			NBPKMLMCHFN.SetFloat("_Speed", Speed);
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1392f)
			{
				HBJJOCHGOPH = 1076f;
			}
			DNLMFEGJJDD().SetFloat("_Distance", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_ScreenResolution", Speed);
			GJHLADDCMFF().SetFloat("ComboScoreText", Distortion);
			OKJOKHGJHGF().SetVector("[RanksSystem] Ranks: no need to update", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 623f, 1106f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1211f)
			{
				HBJJOCHGOPH = 1876f;
			}
			HKGAONMOBMH().SetFloat("_Shadow", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat(":\n", Speed);
			HKHBBBFLGJH().SetFloat(" not exist", Distortion);
			KJMECMIGJJA().SetVector("GlassAberration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1091f, 960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void DGCGGKMNPLD()
	{
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1656f)
			{
				HBJJOCHGOPH = 270f;
			}
			GCDFNHMJMIP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_TimeX", Speed);
			LDNADDJMIPK().SetFloat(":", Distortion);
			DNLMFEGJJDD().SetVector("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1300f, 14f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1077f)
			{
				HBJJOCHGOPH = 1448f;
			}
			GJHLADDCMFF().SetFloat("_FarCamera", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_TimeX", Speed);
			LDNADDJMIPK().SetFloat("SendVacantViewIds()", Distortion);
			OKJOKHGJHGF().SetVector("_Color_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 842f, 1138f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	private void HLDFOJMHKNL()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void PFNFPINPCMH()
	{
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

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 638f)
			{
				HBJJOCHGOPH = 988f;
			}
			OKJOKHGJHGF().SetFloat("_TimeX", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("Drop_Near", Speed);
			OKJOKHGJHGF().SetFloat("quit", Distortion);
			HKGAONMOBMH().SetVector(" Server: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1226f, 559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void LDDKCCMHMIC()
	{
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("RedoButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
