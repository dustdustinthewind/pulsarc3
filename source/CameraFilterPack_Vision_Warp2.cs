// CameraFilterPack_Vision_Warp2
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Warp2")]
public class CameraFilterPack_Vision_Warp2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Value = 0.5f;

	[Range(0f, 1f)]
	public float Value2 = 0.2f;

	[Range(-1f, 2f)]
	public float Intensity = 1f;

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

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("NEW");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
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

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("CameraFilterPack/Gradients_Therma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("ConnectionTimeout");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void HDDECCMEJKA()
	{
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("player.greenlollipop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("Hex value #RRGGBB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_DepthLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 979f)
			{
				HBJJOCHGOPH = 1516f;
			}
			EOCCJGIGEGJ().SetFloat("\"\"", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("Item invalid. No idea why.", Value);
			KGOLDDBHIFN().SetFloat("_BlurParams", Value2);
			KBOPGONOCNP().SetFloat("sprite", Intensity);
			NBPKMLMCHFN.SetFloat("maps.", CCIENBFIKKH);
			DEFBJOCJJKF().SetVector("ShadersToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1576f, 690f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 549f)
			{
				HBJJOCHGOPH = 1363f;
			}
			HEHKGPKLAKK().SetFloat("]", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_BlurRadius4", Value);
			KBOPGONOCNP().SetFloat("Tab2Content", Value2);
			NBPKMLMCHFN.SetFloat("tintColor", Intensity);
			EOCCJGIGEGJ().SetFloat("resetach21", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_BorderSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1310f, 1759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1475f)
			{
				HBJJOCHGOPH = 1459f;
			}
			EOCCJGIGEGJ().SetFloat("id", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/FX_Glitch1", Value);
			KGOLDDBHIFN().SetFloat("_Offsets", Value2);
			KBOPGONOCNP().SetFloat(" - ", Intensity);
			HEHKGPKLAKK().SetFloat("Mouse Y", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("PlayMapsSeriesGoal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 732f, 1206f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1452f)
			{
				HBJJOCHGOPH = 1749f;
			}
			DEFBJOCJJKF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_MainTex2", Value);
			NBPKMLMCHFN.SetFloat("list", Value2);
			EOCCJGIGEGJ().SetFloat("Event Received", Intensity);
			KBOPGONOCNP().SetFloat("effector", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("Stream did not contain properly formatted byte array", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 669f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("tagElement");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 544f)
			{
				HBJJOCHGOPH = 738f;
			}
			KGOLDDBHIFN().SetFloat("LevelProgressBar", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("USE_DIAG_SEARCH", Value);
			EOCCJGIGEGJ().SetFloat("_Value4", Value2);
			FAIFBBGFAIB().SetFloat("[ImageLoader] Loaded image from ", Intensity);
			NBPKMLMCHFN.SetFloat("Error: You're not logged into Steam!", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("Apr", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 555f, 1905f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void HMNLHMLILKD()
	{
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1472f)
			{
				HBJJOCHGOPH = 1641f;
			}
			DEFBJOCJJKF().SetFloat("_TimeX", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat(" does not exist!", Value);
			DOHGBNPMBKG().SetFloat("BitsData", Value2);
			KAFBNOBOIAJ().SetFloat("SetRoomStartTimestamp", Intensity);
			HEHKGPKLAKK().SetFloat("_MiddleGrey", CCIENBFIKKH);
			HEHKGPKLAKK().SetVector("AddEnvironmentObject", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1514f, 513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_NoOuterClip");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Darken");
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

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("Done!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("float,2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Warp2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
			NBPKMLMCHFN.SetFloat("_Value2", Value2);
			NBPKMLMCHFN.SetFloat("_Value3", Intensity);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 0f)
			{
				HBJJOCHGOPH = 1567f;
			}
			KGOLDDBHIFN().SetFloat("/", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", Value);
			HEHKGPKLAKK().SetFloat("Hip-hop", Value2);
			HEHKGPKLAKK().SetFloat("_Value1", Intensity);
			FAIFBBGFAIB().SetFloat("_TimeX", CCIENBFIKKH);
			HEHKGPKLAKK().SetVector("colorD", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1658f, 827f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 965f)
			{
				HBJJOCHGOPH = 1067f;
			}
			KGOLDDBHIFN().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("Tab2Content", Value);
			NBPKMLMCHFN.SetFloat("SettingsCanvas", Value2);
			KAFBNOBOIAJ().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", Intensity);
			KAFBNOBOIAJ().SetFloat("B", CCIENBFIKKH);
			EOCCJGIGEGJ().SetVector("HitInRelaxMusicToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1438f, 1928f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void LLJLDLLNFBH()
	{
	}

	private void LEAHIBJDMBI()
	{
	}

	private void KMKLDAJLCNM()
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
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
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

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
