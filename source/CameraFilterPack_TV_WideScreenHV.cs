// CameraFilterPack_TV_WideScreenHV
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/WideScreenHV")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenHV : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	[Range(0.001f, 0.4f)]
	public float Smooth = 0.01f;

	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;

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

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("Left Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("VoteUpToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1345f)
			{
				HBJJOCHGOPH = 511f;
			}
			NBPKMLMCHFN.SetFloat("_BlurCoe", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("BitsData", Size);
			DBOLLHHMKKN().SetFloat("\"", Smooth);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", ICABEDDNGIH);
			MCDGIILBNIF().SetFloat("Joystick1Button11", LHOMPJOPKHE);
			MCDGIILBNIF().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 670f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_CurveTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 550f)
			{
				HBJJOCHGOPH = 1403f;
			}
			NBPKMLMCHFN.SetFloat("Drop_Far", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_Value7", Size);
			EHDJJANLINB().SetFloat("_Value2", Smooth);
			CIAFLBFJLEJ().SetFloat("MapConfig", ICABEDDNGIH);
			BFGNMFCNDBC().SetFloat("Set object anchor to another object", LHOMPJOPKHE);
			KDMBOKLMADJ().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 416f, 456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_Value");
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
			if (HBJJOCHGOPH > 184f)
			{
				HBJJOCHGOPH = 1113f;
			}
			KDMBOKLMADJ().SetFloat("0.00", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat(").png", Size);
			FHFLKLMFHOI().SetFloat("z", Smooth);
			OGMEGHKECAH().SetFloat("The observed monobehaviour (", ICABEDDNGIH);
			DBOLLHHMKKN().SetFloat("grid", LHOMPJOPKHE);
			KDMBOKLMADJ().SetVector("Observed type is not serializable: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 572f, 1564f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void FOLDLDLFFLM()
	{
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find(" url: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 14f)
			{
				HBJJOCHGOPH = 627f;
			}
			OGMEGHKECAH().SetFloat("_Green_R", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat(" - ", Size);
			LNLKMDPHDCC().SetFloat("_Value", Smooth);
			EHDJJANLINB().SetFloat("PointsScoreText", ICABEDDNGIH);
			MCDGIILBNIF().SetFloat("workshop.", LHOMPJOPKHE);
			MMOODGIODPC().SetVector("OnStatusChanged: {0} current State: {1}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1992f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void LLKKGGLNIDF()
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
			if (HBJJOCHGOPH > 1119f)
			{
				HBJJOCHGOPH = 1545f;
			}
			KAFBNOBOIAJ().SetFloat("_TimeX", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("JITTER", Size);
			CEKJODEAMGB().SetFloat("OpJoinRoom()", Smooth);
			BFGNMFCNDBC().SetFloat("In Main Menu", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("_AccumOrig", LHOMPJOPKHE);
			JLHLHKPHDFO().SetVector("_BlurRadius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1390f, 1757f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 265f)
			{
				HBJJOCHGOPH = 713f;
			}
			CEKJODEAMGB().SetFloat("OpJoinRoom()", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("No child content found, exiting..", Size);
			MMOODGIODPC().SetFloat("icon", Smooth);
			OCHJIMJNEMO().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", ICABEDDNGIH);
			MCDGIILBNIF().SetFloat("player.orangearc", LHOMPJOPKHE);
			MCDGIILBNIF().SetVector(" BETA", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 454f, 1996f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1952f)
			{
				HBJJOCHGOPH = 1172f;
			}
			LNLKMDPHDCC().SetFloat("inventory.selected.", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("_MainTex2", Size);
			EHDJJANLINB().SetFloat("_Value4", Smooth);
			LONNIJMNKFB().SetFloat("_NoiseTex", ICABEDDNGIH);
			CIAFLBFJLEJ().SetFloat("Set satellite color", LHOMPJOPKHE);
			GJHPODJOBHL().SetVector("CameraFilterPack/Color_Contrast", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1693f, 326f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 127f)
			{
				HBJJOCHGOPH = 1504f;
			}
			CEKJODEAMGB().SetFloat("id", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat(" PhotonView: ", Size);
			CEKJODEAMGB().SetFloat("<color=#{0}>{1}</color>", Smooth);
			KAFBNOBOIAJ().SetFloat("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", ICABEDDNGIH);
			LNLKMDPHDCC().SetFloat("_Value2", LHOMPJOPKHE);
			LNLKMDPHDCC().SetVector("The shader ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 1599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("masterSteamID");
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
			if (HBJJOCHGOPH > 1363f)
			{
				HBJJOCHGOPH = 1929f;
			}
			LNLKMDPHDCC().SetFloat("Set Trail Zoom (player camera move forward effect). Base value - 1.5", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("ICollection", Size);
			CIAFLBFJLEJ().SetFloat(".icon", Smooth);
			BFGNMFCNDBC().SetFloat("Set Satellite Color", ICABEDDNGIH);
			JLHLHKPHDFO().SetFloat("AccuracyScoreText", LHOMPJOPKHE);
			DNLMFEGJJDD().SetVector("player.russia", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1273f, 1057f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1987f)
			{
				HBJJOCHGOPH = 1208f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper2", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_TimeX", Size);
			CIAFLBFJLEJ().SetFloat(".lastCheckpoint.time", Smooth);
			KAFBNOBOIAJ().SetFloat("player", ICABEDDNGIH);
			BFGNMFCNDBC().SetFloat("_BgColor", LHOMPJOPKHE);
			KAFBNOBOIAJ().SetVector("file://", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 572f, 398f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void AIJGAJIOJDJ()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 421f)
			{
				HBJJOCHGOPH = 35f;
			}
			LNLKMDPHDCC().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("yyyy-MM-dd HH:mm:ss", Size);
			KDMBOKLMADJ().SetFloat("_Value6", Smooth);
			DBOLLHHMKKN().SetFloat("UsernameText", ICABEDDNGIH);
			EHDJJANLINB().SetFloat("DPADHOR", LHOMPJOPKHE);
			CIAFLBFJLEJ().SetVector("settings.gamemessagesduration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 145f, 359f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 821f)
			{
				HBJJOCHGOPH = 1584f;
			}
			BFGNMFCNDBC().SetFloat("_Value4", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("workshop.", Size);
			GJHPODJOBHL().SetFloat("#close", Smooth);
			LNLKMDPHDCC().SetFloat("Joystick1Button5", ICABEDDNGIH);
			DBOLLHHMKKN().SetFloat("_SunThreshold", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 167f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
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

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1021f)
			{
				HBJJOCHGOPH = 1488f;
			}
			KDMBOKLMADJ().SetFloat("Operation failed: ", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_TimeX", Size);
			CEKJODEAMGB().SetFloat("\"x", Smooth);
			EHDJJANLINB().SetFloat("_Value3", ICABEDDNGIH);
			OGMEGHKECAH().SetFloat("_MainTex", LHOMPJOPKHE);
			KAFBNOBOIAJ().SetVector("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1771f, 302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 268f)
			{
				HBJJOCHGOPH = 645f;
			}
			OCHJIMJNEMO().SetFloat("<b>Difficulty</b>:", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_VelTex", Size);
			JLHLHKPHDFO().SetFloat("ready", Smooth);
			CEKJODEAMGB().SetFloat("0.00", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("_TimeX", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 49f)
			{
				HBJJOCHGOPH = 479f;
			}
			DNLMFEGJJDD().SetFloat("closed", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("UI", Size);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/Broken_Screen", Smooth);
			CIAFLBFJLEJ().SetFloat("offline", ICABEDDNGIH);
			MCDGIILBNIF().SetFloat("id", LHOMPJOPKHE);
			JLHLHKPHDFO().SetVector("File not found: {0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1552f, 942f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void FABMDEHEDNO()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 93f)
			{
				HBJJOCHGOPH = 1674f;
			}
			FHFLKLMFHOI().SetFloat(".completed", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("CameraFilterPack/Noise_TV_3", Size);
			JLHLHKPHDFO().SetFloat("_Value2", Smooth);
			IONHGBPGCHK().SetFloat("Editor", ICABEDDNGIH);
			DNLMFEGJJDD().SetFloat("Set satellite trail width", LHOMPJOPKHE);
			OGMEGHKECAH().SetVector("Fill", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 892f, 1648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 598f)
			{
				HBJJOCHGOPH = 504f;
			}
			EHDJJANLINB().SetFloat("RequestSelectedLevel", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("IconImage", Size);
			IONHGBPGCHK().SetFloat("Set Sun Sensitivity", Smooth);
			KDMBOKLMADJ().SetFloat("Circle", ICABEDDNGIH);
			IONHGBPGCHK().SetFloat("_Speed", LHOMPJOPKHE);
			FHFLKLMFHOI().SetVector("r", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 41f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void OBAEDJJDCPN()
	{
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 982f)
			{
				HBJJOCHGOPH = 1832f;
			}
			OCHJIMJNEMO().SetFloat("[SaveSystem] Outdated savefile found", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_Value3", Size);
			CIAFLBFJLEJ().SetFloat("appid", Smooth);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", ICABEDDNGIH);
			FHFLKLMFHOI().SetFloat("NEW_ACHIEVEMENT_1_", LHOMPJOPKHE);
			KAFBNOBOIAJ().SetVector("CameraFilterPack/3D_Inverse", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1661f, 1513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("note.1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 539f)
			{
				HBJJOCHGOPH = 329f;
			}
			IONHGBPGCHK().SetFloat("1177138211", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("checkpoint", Size);
			DNLMFEGJJDD().SetFloat("_Value2", Smooth);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_Difference", ICABEDDNGIH);
			IONHGBPGCHK().SetFloat("_FixDistance", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("' was created: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1552f, 1110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 411f)
			{
				HBJJOCHGOPH = 1067f;
			}
			EHDJJANLINB().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("TransferOwnership() view ", Size);
			CIAFLBFJLEJ().SetFloat("LevelNameInputField", Smooth);
			IONHGBPGCHK().SetFloat("Set sun lerp speed", ICABEDDNGIH);
			GJHPODJOBHL().SetFloat("[LevelEditorScene] Print Audio Wave: Start", LHOMPJOPKHE);
			BFGNMFCNDBC().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1421f, 1680f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_WideScreenHV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("Error: You're not logged into Steam!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("player.xp");
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", Smooth);
			NBPKMLMCHFN.SetFloat("_Value3", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("_Value4", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1123f)
			{
				HBJJOCHGOPH = 191f;
			}
			CIAFLBFJLEJ().SetFloat("1427616858", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("NEW_ACHIEVEMENT_1_", Size);
			MMOODGIODPC().SetFloat("_TimeX", Smooth);
			OCHJIMJNEMO().SetFloat(" ", ICABEDDNGIH);
			CEKJODEAMGB().SetFloat("_Jitter", LHOMPJOPKHE);
			OGMEGHKECAH().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 410f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			if (HBJJOCHGOPH > 392f)
			{
				HBJJOCHGOPH = 862f;
			}
			MMOODGIODPC().SetFloat("DPADHOR", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("SlidingArea", Size);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", Smooth);
			CIAFLBFJLEJ().SetFloat("settings.selectormapsperpage", ICABEDDNGIH);
			KDMBOKLMADJ().SetFloat("GroupNameText", LHOMPJOPKHE);
			OGMEGHKECAH().SetVector("Had to lookup view that wasn't in photonViewList: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 885f, 1998f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 813f)
			{
				HBJJOCHGOPH = 1951f;
			}
			JLHLHKPHDFO().SetFloat("http", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("X", Size);
			GJHPODJOBHL().SetFloat(" x ", Smooth);
			KDMBOKLMADJ().SetFloat("GetGameList failed: ", ICABEDDNGIH);
			KAFBNOBOIAJ().SetFloat("_HexaColor", LHOMPJOPKHE);
			CEKJODEAMGB().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 642f, 957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 579f)
			{
				HBJJOCHGOPH = 815f;
			}
			EHDJJANLINB().SetFloat("PUN-instantiated '", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", Size);
			MCDGIILBNIF().SetFloat("</i>", Smooth);
			CEKJODEAMGB().SetFloat("_History3LumaTex", ICABEDDNGIH);
			GJHPODJOBHL().SetFloat("Mouse Wheel Down", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 854f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GCDLIKEDMCF()
	{
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 179f)
			{
				HBJJOCHGOPH = 1114f;
			}
			DNLMFEGJJDD().SetFloat("float,0", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("LeaderboardsButton", Size);
			IONHGBPGCHK().SetFloat("Change Note:", Smooth);
			KAFBNOBOIAJ().SetFloat("\n\n#", ICABEDDNGIH);
			KDMBOKLMADJ().SetFloat("file://", LHOMPJOPKHE);
			KAFBNOBOIAJ().SetVector("CameraFilterPack/FX_8bits_gb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1745f, 903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("MainCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("Waiting for AvailableRegions. State: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("player.abstract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void APKNAPHOFHC()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}
}
