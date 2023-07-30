// CameraFilterPack_Film_Grain
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Film/Grain")]
[ExecuteInEditMode]
public class CameraFilterPack_Film_Grain : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-64f, 64f)]
	public float Value = 32f;

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
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HNDNDPECBPL()
	{
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("CameraFilterPack/BlurTiltShift_Hole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find(" but this PhotonView does not exist! View was/is ours.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("Fade");
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
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
			if (HBJJOCHGOPH > 1765f)
			{
				HBJJOCHGOPH = 334f;
			}
			OIIDAKBILMI().SetFloat(".wav", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("#useticket", Value);
			FGENHBKMPDA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 265f, 911f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
			if (HBJJOCHGOPH > 1188f)
			{
				HBJJOCHGOPH = 1326f;
			}
			NLFJGMBCICG().SetFloat("Uploader", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_MainTex", Value);
			IGIAPKPKGPK().SetVector("[ItemsHandler] No connection to item server: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 519f, 465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CAKNMILHHNE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DIGHKAJILJH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHIJGCLBMJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void FABMDEHEDNO()
	{
	}

	[SpecialName]
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ILKALHDJBFE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void BKIGIIINEDH()
	{
		SCShader = Shader.Find("_Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 4f)
			{
				HBJJOCHGOPH = 1046f;
			}
			PDEAHJPOMEF().SetFloat(" Also make sure to disable sprite packing for this sprite.", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("CameraFilterPack/FX_8bits_gb", Value);
			NBPKMLMCHFN.SetVector("PopulateMapsList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1464f, 1407f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1212f)
			{
				HBJJOCHGOPH = 41f;
			}
			IGKFMCPDNOI().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat(".GoalProgress", Value);
			IFMAPIDFNLI().SetVector("title", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1877f, 1293f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("GhostPosX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_LutTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1499f)
			{
				HBJJOCHGOPH = 946f;
			}
			NMDBCDFPGOK().SetFloat("_Offsets", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat(".lastCheckpoint.perfectHits", Value);
			ACHNOHCLGOO().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 520f, 675f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1663f)
			{
				HBJJOCHGOPH = 726f;
			}
			NMDBCDFPGOK().SetFloat("{0}sec average:", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_TimeX", Value);
			LMLENGFLEBD().SetVector("file://", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1386f, 598f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void LBPCODPOJAH()
	{
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1335f)
			{
				HBJJOCHGOPH = 312f;
			}
			IFMAPIDFNLI().SetFloat("_Value4", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat(" not exist", Value);
			HKHBBBFLGJH().SetVector("AudioClip", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 96f, 111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HCDBNAKGDJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void JNBPKNNBMDI()
	{
	}

	private void OEIBFOHPOPD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 986f)
			{
				HBJJOCHGOPH = 1126f;
			}
			ILKALHDJBFE().SetFloat("getstring", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("1 Kb", Value);
			HFBJAOFLCJI().SetVector("_Saturation", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 111f, 377f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("_Extra2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("settings.cameramovements");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("colorD");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 899f)
			{
				HBJJOCHGOPH = 1357f;
			}
			HCGJCMDJPGD().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("ItemNameBGImage", Value);
			NBPKMLMCHFN.SetVector("float,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1503f, 1914f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("caret");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMNOHLNANIP()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 509f)
			{
				HBJJOCHGOPH = 401f;
			}
			HCGJCMDJPGD().SetFloat("_NoiseTex", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_ScreenResolution", Value);
			KBOPGONOCNP().SetVector("ResetSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 463f, 990f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void COMNAPAAPDO()
	{
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void NKLIHNJCHOG()
	{
	}

	private void JEBIBKLHFLB()
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

	private void IKMELABKBHO()
	{
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1023f)
			{
				HBJJOCHGOPH = 1461f;
			}
			IGIAPKPKGPK().SetFloat("maps.", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("default", Value);
			DKKBFFHBHJE().SetVector("menu.tabid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1918f, 11f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 390f)
			{
				HBJJOCHGOPH = 1636f;
			}
			HNICHJCGJOC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("settings.enableselectormusic", Value);
			LMLENGFLEBD().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 595f, 90f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("MessageText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 492f)
			{
				HBJJOCHGOPH = 189f;
			}
			OIIDAKBILMI().SetFloat("_PositionX", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("Player", Value);
			HKHBBBFLGJH().SetVector("_SizeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 4f, 912f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1022f)
			{
				HBJJOCHGOPH = 710f;
			}
			IFMAPIDFNLI().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("MessageText", Value);
			ILKALHDJBFE().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1060f, 234f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1129f)
			{
				HBJJOCHGOPH = 267f;
			}
			DIOAAHJDMLK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("[PlayerController] ", Value);
			ILKALHDJBFE().SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1926f, 1254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 726f)
			{
				HBJJOCHGOPH = 1699f;
			}
			KBOPGONOCNP().SetFloat("Set particles count per one beat", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", Value);
			PDEAHJPOMEF().SetVector("null", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 602f, 1257f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ODMPMJPALID()
	{
		SCShader = Shader.Find("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_Manga");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PNLKFANNOKO()
	{
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1827f)
			{
				HBJJOCHGOPH = 1234f;
			}
			LPMLLJKMAMP().SetFloat("workshop.", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_EmissionColor", Value);
			DBOLLHHMKKN().SetVector("Type of observed is unknown when receiving.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 711f, 463f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1394f)
			{
				HBJJOCHGOPH = 838f;
			}
			HFBJAOFLCJI().SetFloat("13", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", Value);
			NLFJGMBCICG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 95f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("Have you fully accept the terms?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 152f)
			{
				HBJJOCHGOPH = 155f;
			}
			OIIDAKBILMI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("Load Game", Value);
			DKKBFFHBHJE().SetVector("CameraFilterPack/TV_BrokenGlass2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1517f, 1118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Film_Grain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1088f)
			{
				HBJJOCHGOPH = 381f;
			}
			PDEAHJPOMEF().SetFloat("YES", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("bloomintencity:", Value);
			DIOAAHJDMLK().SetVector("CameraFilterPack/Colors_NewPosterize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 341f, 1083f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1999f)
			{
				HBJJOCHGOPH = 821f;
			}
			NBMPPNFKFLB().SetFloat("_Value2", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("_MinVelocity", Value);
			KBOPGONOCNP().SetVector("recipes", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 168f, 1282f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void AEMGPJDJGBJ()
	{
		SCShader = Shader.Find("hardcoreinfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABFNJCEBIKA()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	private void DNENFLNCIJP()
	{
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("SetBGColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 85f)
			{
				HBJJOCHGOPH = 1051f;
			}
			PDEAHJPOMEF().SetFloat(" : ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value2", Value);
			NFKFAAHHLLM().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 156f, 846f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 372f)
			{
				HBJJOCHGOPH = 327f;
			}
			LNLKMDPHDCC().SetFloat("_RampOffset", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Offsets", Value);
			OIIDAKBILMI().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 480f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void JHPOIOELNCG()
	{
	}

	private void EIDKCANPHJE()
	{
	}

	private void EJFJENFKLND()
	{
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1765f)
			{
				HBJJOCHGOPH = 1769f;
			}
			KJMECMIGJJA().SetFloat("[ItemsHandler] Loading Steam inventory", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_Val", Value);
			HNICHJCGJOC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 127f, 35f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 776f)
			{
				HBJJOCHGOPH = 1386f;
			}
			NLFJGMBCICG().SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("[MapEditor] Updating top menu", Value);
			IFMAPIDFNLI().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 157f, 448f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 445f)
			{
				HBJJOCHGOPH = 672f;
			}
			ACHNOHCLGOO().SetFloat("Tab2Content", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("ShadersToggle", Value);
			LDNADDJMIPK().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 174f, 601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 832f)
			{
				HBJJOCHGOPH = 1243f;
			}
			DIOAAHJDMLK().SetFloat("SpawnObj", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("maps.", Value);
			KJMECMIGJJA().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 122f, 89f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 691f)
			{
				HBJJOCHGOPH = 987f;
			}
			LNLKMDPHDCC().SetFloat("[", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("value", Value);
			ABHDNGIHBKE().SetVector("selColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 66f, 1187f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JCGMGLMADEN()
	{
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 247f)
			{
				HBJJOCHGOPH = 642f;
			}
			LPMLLJKMAMP().SetFloat("_Value", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("menu.selectedlevelid", Value);
			ABHDNGIHBKE().SetVector("R:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1031f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDDPLJGKLKJ()
	{
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EDPDMBFLHLP()
	{
		SCShader = Shader.Find(".completedMaps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void OBDEJFCNOBF()
	{
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
