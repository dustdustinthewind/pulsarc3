// CameraFilterPack_Color_Contrast
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Colors/Contrast")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Contrast : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 10f)]
	public float Contrast = 4.5f;

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

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("PhotonMono");
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
			if (HBJJOCHGOPH > 1591f)
			{
				HBJJOCHGOPH = 651f;
			}
			NMDBCDFPGOK().SetFloat("randomdrop", Contrast);
			OHKGGPFGLFD().SetFloat("_Value", HBJJOCHGOPH);
			PHGCJOPFDOG().SetVector("USE_PREDICATION", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1419f, 231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_Green_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GMELGGJOPBB()
	{
	}

	private void MMBPLGGLPDB()
	{
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Color_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 790f)
			{
				HBJJOCHGOPH = 36f;
			}
			AELJLBOJAIL().SetFloat("Square", Contrast);
			OLHDPICFBOF().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", HBJJOCHGOPH);
			HNICHJCGJOC().SetVector("_Level", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 402f, 159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find("CameraFilterPack_eyes_vision_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MPENCEIGLEH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1321f)
			{
				HBJJOCHGOPH = 252f;
			}
			DKKBFFHBHJE().SetFloat("_ScreenResolution", Contrast);
			IGIAPKPKGPK().SetFloat("CameraFilterPack/Noise_TV", HBJJOCHGOPH);
			NJDIODJNGGA().SetVector("Joystick1Button0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1824f, 122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find(" - ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void COGBDFKOHKK()
	{
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1401f)
			{
				HBJJOCHGOPH = 1126f;
			}
			DIOAAHJDMLK().SetFloat("ERROR: preview file name is empty in modName.workshop.json", Contrast);
			ADAFMBOGPLN().SetFloat("SpawnObj", HBJJOCHGOPH);
			JCPDCGIJKJD().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 762f, 1380f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHIJGCLBMJL()
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

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GBFOAHKAJEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1797f)
			{
				HBJJOCHGOPH = 545f;
			}
			DKKBFFHBHJE().SetFloat("DPADHOR", Contrast);
			NBPKMLMCHFN.SetFloat("#random #common #item", HBJJOCHGOPH);
			DKKBFFHBHJE().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1432f, 1629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find(".lastCheckpoint.currentCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1738f)
			{
				HBJJOCHGOPH = 1430f;
			}
			IGIAPKPKGPK().SetFloat("_ContrastGainGamma", Contrast);
			HEINDEMCGIK().SetFloat("_FadeFX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetVector("settings.shaders", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1150f, 660f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1639f)
			{
				HBJJOCHGOPH = 1651f;
			}
			HKHBBBFLGJH().SetFloat("_Speed", Contrast);
			DIOAAHJDMLK().SetFloat("#yes", HBJJOCHGOPH);
			AELJLBOJAIL().SetVector("rarity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 755f, 891f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void IKMELABKBHO()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1795f)
			{
				HBJJOCHGOPH = 1931f;
			}
			ELBMIEOIABA().SetFloat("] to be droppable", Contrast);
			KBOPGONOCNP().SetFloat("Jan", HBJJOCHGOPH);
			JCPDCGIJKJD().SetVector("Joystick1Button2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 384f, 720f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 964f)
			{
				HBJJOCHGOPH = 295f;
			}
			LEIAFCPJMDP().SetFloat("id", Contrast);
			HKIMAANBGMJ().SetFloat("[RanksSystem] Init", HBJJOCHGOPH);
			KBOPGONOCNP().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1655f, 1215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 365f)
			{
				HBJJOCHGOPH = 183f;
			}
			DBOLLHHMKKN().SetFloat("Search: ", Contrast);
			DIOAAHJDMLK().SetFloat("menutheme.letitbe", HBJJOCHGOPH);
			MPENCEIGLEH().SetVector("OpJoinRoom()", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 384f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 453f)
			{
				HBJJOCHGOPH = 1962f;
			}
			NBPKMLMCHFN.SetFloat("player.currentrank", Contrast);
			DKKBFFHBHJE().SetFloat("checkpoint", HBJJOCHGOPH);
			AELJLBOJAIL().SetVector("Loss ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1454f, 654f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1412f)
			{
				HBJJOCHGOPH = 1639f;
			}
			KBOPGONOCNP().SetFloat("_Value3", Contrast);
			AELJLBOJAIL().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			LONNIJMNKFB().SetVector(".message", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 228f, 1426f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("???");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 122f)
			{
				HBJJOCHGOPH = 277f;
			}
			HKIMAANBGMJ().SetFloat("_Offsets", Contrast);
			HKIMAANBGMJ().SetFloat("HiddenToggle", HBJJOCHGOPH);
			INOBFNCKFGK().SetVector("1427616858", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1224f, 1972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1058f)
			{
				HBJJOCHGOPH = 629f;
			}
			KBOPGONOCNP().SetFloat("_Value6", Contrast);
			DKKBFFHBHJE().SetFloat("FinalScoreSmallText", HBJJOCHGOPH);
			PHGCJOPFDOG().SetVector("CameraFilterPack_OldFilm2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 12f, 1906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COMNAPAAPDO()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1484f)
			{
				HBJJOCHGOPH = 878f;
			}
			OLHDPICFBOF().SetFloat("_Value", Contrast);
			MICHFGAOPKM().SetFloat("_Offsets", HBJJOCHGOPH);
			NBPKMLMCHFN.SetVector("_Far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1687f, 1118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			if (HBJJOCHGOPH > 975f)
			{
				HBJJOCHGOPH = 46f;
			}
			NJDIODJNGGA().SetFloat("z", Contrast);
			MPENCEIGLEH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IGIAPKPKGPK().SetVector("ItemNameBGImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1573f, 1719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANKIJGCGCBF()
	{
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("_SoftZDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("ShineEffect");
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
			NBPKMLMCHFN.SetFloat("_Contrast", Contrast);
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 930f)
			{
				HBJJOCHGOPH = 769f;
			}
			NFMGLIKNOOC().SetFloat("_ScreenResolution", Contrast);
			MNLKBFFKHIE().SetFloat("_Value", HBJJOCHGOPH);
			MNLKBFFKHIE().SetVector("CameraFilterPack/TV_WideScreenCircle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 868f, 919f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 581f)
			{
				HBJJOCHGOPH = 183f;
			}
			ADAFMBOGPLN().SetFloat("_Green_R", Contrast);
			HKHBBBFLGJH().SetFloat(".a", HBJJOCHGOPH);
			HKIMAANBGMJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1398f, 1240f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1200f)
			{
				HBJJOCHGOPH = 182f;
			}
			ADAFMBOGPLN().SetFloat("_Value2", Contrast);
			MNLKBFFKHIE().SetFloat("return CheckCondition()", HBJJOCHGOPH);
			DIOAAHJDMLK().SetVector("Can't set open when not in that room.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 514f, 1645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LDDKCCMHMIC()
	{
	}

	private void CKECPMDEBLL()
	{
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void KKLMPKLKAEM()
	{
	}

	private void HEBOIFKBLGD()
	{
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("Most likely the game became empty during the switch to GameServer.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1206f)
			{
				HBJJOCHGOPH = 72f;
			}
			HNICHJCGJOC().SetFloat("Editor/", Contrast);
			MICHFGAOPKM().SetFloat("CameraFilterPack/3D_Myst", HBJJOCHGOPH);
			DKKBFFHBHJE().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 742f, 861f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void CIHGFHNNFEE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFMEAMBLODG()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return BJFKDHHMLJH;
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
	}

	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1515f)
			{
				HBJJOCHGOPH = 1409f;
			}
			NFMGLIKNOOC().SetFloat("Cross", Contrast);
			JCPDCGIJKJD().SetFloat("_Value4", HBJJOCHGOPH);
			NJDIODJNGGA().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1493f, 1902f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("Remove Environment Object");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void DKEHGPPOKEA()
	{
		SCShader = Shader.Find("player.playedtutorial");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBFJAOINHMK()
	{
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("CameraFilterPack_AAA_BloodOnScreen1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BFGIMALGMAJ()
	{
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("Bad parameters for setint! Use <key> <value>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OMCLOFCJMPG()
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
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 488f)
			{
				HBJJOCHGOPH = 138f;
			}
			DKKBFFHBHJE().SetFloat("SupportLogger OnDisconnectedFromPhoton().", Contrast);
			LONNIJMNKFB().SetFloat("_BlueAmplifier", HBJJOCHGOPH);
			LEIAFCPJMDP().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1218f)
			{
				HBJJOCHGOPH = 425f;
			}
			KEMJNOMIPHN().SetFloat("': ", Contrast);
			KBOPGONOCNP().SetFloat(".lastCheckpoint.perfectHits", HBJJOCHGOPH);
			LONNIJMNKFB().SetVector("_Red_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 370f, 1744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1172f)
			{
				HBJJOCHGOPH = 481f;
			}
			ADAFMBOGPLN().SetFloat("InfoText", Contrast);
			DKKBFFHBHJE().SetFloat("<scene_name> or <id>", HBJJOCHGOPH);
			ELBMIEOIABA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1140f, 595f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1318f)
			{
				HBJJOCHGOPH = 620f;
			}
			HKHBBBFLGJH().SetFloat("UseScanLine", Contrast);
			LONNIJMNKFB().SetFloat("_Offsets", HBJJOCHGOPH);
			DBOLLHHMKKN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 268f, 1718f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1405f)
			{
				HBJJOCHGOPH = 826f;
			}
			MPENCEIGLEH().SetFloat("_Bloom1", Contrast);
			MNLKBFFKHIE().SetFloat("_Value4", HBJJOCHGOPH);
			ADAFMBOGPLN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 296f, 266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 145f)
			{
				HBJJOCHGOPH = 1505f;
			}
			MPENCEIGLEH().SetFloat("Coord", Contrast);
			KEMJNOMIPHN().SetFloat(",", HBJJOCHGOPH);
			GBFOAHKAJEK().SetVector(". The group number should be at least 1.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1378f, 320f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Twist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 637f)
			{
				HBJJOCHGOPH = 503f;
			}
			HKIMAANBGMJ().SetFloat("_VignetteDesat", Contrast);
			DBOLLHHMKKN().SetFloat("closed", HBJJOCHGOPH);
			MICHFGAOPKM().SetVector(" / Sample Count: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 51f, 312f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1166f)
			{
				HBJJOCHGOPH = 1378f;
			}
			DIOAAHJDMLK().SetFloat("  |  ", Contrast);
			ELBMIEOIABA().SetFloat("DISTORT", HBJJOCHGOPH);
			LEIAFCPJMDP().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1878f, 833f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 985f)
			{
				HBJJOCHGOPH = 291f;
			}
			KBOPGONOCNP().SetFloat("#no", Contrast);
			LONNIJMNKFB().SetFloat("_Value3", HBJJOCHGOPH);
			OLHDPICFBOF().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1765f, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 6f)
			{
				HBJJOCHGOPH = 68f;
			}
			HEINDEMCGIK().SetFloat("id", Contrast);
			HKIMAANBGMJ().SetFloat("#tryagain", HBJJOCHGOPH);
			NMDBCDFPGOK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1973f, 779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEFHGMNAPEP()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void IDIIELPAMCJ()
	{
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 120f)
			{
				HBJJOCHGOPH = 1263f;
			}
			JCPDCGIJKJD().SetFloat("<b>", Contrast);
			NFMGLIKNOOC().SetFloat("PUN-instantiated '", HBJJOCHGOPH);
			DIOAAHJDMLK().SetVector("OnPressRight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 708f, 224f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ELBMIEOIABA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}
}
