// CameraFilterPack_Gradients_Ansi
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Gradients/Ansi")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_Ansi : MonoBehaviour
{
	public Shader SCShader;

	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Ansi";

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	private float ALGIDJONBGN;

	[Range(0f, 1f)]
	private float IMNDKCGGPEH = 0.2f;

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

	private void ALNNIDLFILB()
	{
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 254f)
			{
				HBJJOCHGOPH = 141f;
			}
			BBIMPFGLDCP().SetFloat("_SpherePositionX", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("#done", ALGIDJONBGN);
			EJDPNJAEAKJ().SetFloat(".g", IMNDKCGGPEH);
			PDEAHJPOMEF().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 295f, 818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 431f)
			{
				HBJJOCHGOPH = 726f;
			}
			DIOAAHJDMLK().SetFloat("ResourcesConfig", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Antialiasing_FXAA", ALGIDJONBGN);
			HHLFDHNEIAH().SetFloat("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", IMNDKCGGPEH);
			EMDFHOKEGNG().SetVector("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 115f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 52f)
			{
				HBJJOCHGOPH = 1999f;
			}
			DIOAAHJDMLK().SetFloat("player.mysteryitem", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/FX_Grid", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("#forever", IMNDKCGGPEH);
			HKIMAANBGMJ().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 602f, 720f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COIJKMKIEAK()
	{
	}

	private void CCFEDENFNEF()
	{
	}

	private void FHPFJBFCOOF()
	{
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEHCNJLLJMP()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1221f)
			{
				HBJJOCHGOPH = 916f;
			}
			OIIDAKBILMI().SetFloat("_Value4", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("Set environment sprite color and alpha.", ALGIDJONBGN);
			DIOAAHJDMLK().SetFloat("CameraFilterPack/Glow_Glow", IMNDKCGGPEH);
			NBPKMLMCHFN.SetVector("' has been reset to the fault value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 101f, 1173f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
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
			NBPKMLMCHFN.SetFloat("_Value", ALGIDJONBGN);
			NBPKMLMCHFN.SetFloat("_Value2", IMNDKCGGPEH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1527f)
			{
				HBJJOCHGOPH = 378f;
			}
			MJJIEHANFJA().SetFloat("1159514800", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("#done", ALGIDJONBGN);
			OIIDAKBILMI().SetFloat("/", IMNDKCGGPEH);
			OIIDAKBILMI().SetVector("[PlayerBase] Checkpoint error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 363f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DNNFHBOOPIN()
	{
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NPLCENPNJBM()
	{
	}

	private void EPJJDKJEDMM()
	{
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 687f)
			{
				HBJJOCHGOPH = 1278f;
			}
			HHIAIGCAHDA().SetFloat("menu.tabid", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("#rt", ALGIDJONBGN);
			HHLFDHNEIAH().SetFloat("settings.volume.sfx", IMNDKCGGPEH);
			BBIMPFGLDCP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 533f, 247f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void BNLENEDAHHL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 956f)
			{
				HBJJOCHGOPH = 1394f;
			}
			HHIAIGCAHDA().SetFloat("_MainTex2", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", ALGIDJONBGN);
			KBOPGONOCNP().SetFloat("Beat Detected", IMNDKCGGPEH);
			DBOLLHHMKKN().SetVector("Editor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 57f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 843f)
			{
				HBJJOCHGOPH = 1954f;
			}
			MJJIEHANFJA().SetFloat("EnableRankingToggle", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("ns", ALGIDJONBGN);
			EMDFHOKEGNG().SetFloat("OK", IMNDKCGGPEH);
			EMDFHOKEGNG().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 106f, 112f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1604f)
			{
				HBJJOCHGOPH = 1488f;
			}
			DIOAAHJDMLK().SetFloat("_Extra2", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("float,10", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("_Green_R", IMNDKCGGPEH);
			DBOLLHHMKKN().SetVector("CameraFilterPack/Distortion_Lens", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 838f, 1561f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
	}

	private void EDPDMBFLHLP()
	{
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EHCGBJDFMHG()
	{
	}

	private void FLKEJJEGCFA()
	{
	}

	private void IGPCNCJIEOJ()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 167f)
			{
				HBJJOCHGOPH = 751f;
			}
			HHLFDHNEIAH().SetFloat("#ok", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat(".lastCheckpoint.correctScore", ALGIDJONBGN);
			LMLENGFLEBD().SetFloat("\t", IMNDKCGGPEH);
			EJDPNJAEAKJ().SetVector("set id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 898f, 600f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 940f)
			{
				HBJJOCHGOPH = 510f;
			}
			PDEAHJPOMEF().SetFloat("Rotate environment object to the rotation", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("(\\[ *quote *\\])", ALGIDJONBGN);
			PDEAHJPOMEF().SetFloat(" - Contains ", IMNDKCGGPEH);
			CIAFLBFJLEJ().SetVector("Joystick1Button5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 518f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void CGDMLHLJIDK()
	{
	}

	private void IDJKNBDKHBD()
	{
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void JAAJECBCCFM()
	{
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 714f)
			{
				HBJJOCHGOPH = 556f;
			}
			LMLENGFLEBD().SetFloat("IncorrectHitsScoreText", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat("_PColor", ALGIDJONBGN);
			OIIDAKBILMI().SetFloat("DPADVER", IMNDKCGGPEH);
			OIBHFCLJKDB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 844f, 1261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1035f)
			{
				HBJJOCHGOPH = 1132f;
			}
			CIAFLBFJLEJ().SetFloat("_Value", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_PColor2", ALGIDJONBGN);
			LMLENGFLEBD().SetFloat("_Value6", IMNDKCGGPEH);
			LMLENGFLEBD().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 475f, 1184f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1702f)
			{
				HBJJOCHGOPH = 635f;
			}
			HKIMAANBGMJ().SetFloat("_Value12", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("player.greenlifering", ALGIDJONBGN);
			OIBHFCLJKDB().SetFloat("_MainTex2", IMNDKCGGPEH);
			OIIDAKBILMI().SetVector("1 Kb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1758f, 332f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1962f)
			{
				HBJJOCHGOPH = 231f;
			}
			HKIMAANBGMJ().SetFloat("Left Click", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", ALGIDJONBGN);
			BBIMPFGLDCP().SetFloat("win", IMNDKCGGPEH);
			EMDFHOKEGNG().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1151f, 884f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1828f)
			{
				HBJJOCHGOPH = 798f;
			}
			KBOPGONOCNP().SetFloat("shader.frost", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_SceneFogParams", ALGIDJONBGN);
			LMLENGFLEBD().SetFloat("menu.enableselectormusic", IMNDKCGGPEH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 930f, 12f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 343f)
			{
				HBJJOCHGOPH = 256f;
			}
			NLFJGMBCICG().SetFloat(" - StoreAuthURLResponse] - ", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_MaxVelocity", ALGIDJONBGN);
			HHLFDHNEIAH().SetFloat("AvatarImage", IMNDKCGGPEH);
			PDEAHJPOMEF().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 382f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 623f)
			{
				HBJJOCHGOPH = 1905f;
			}
			KBOPGONOCNP().SetFloat("_Source", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("speed", ALGIDJONBGN);
			KBOPGONOCNP().SetFloat("Joystick1Button11", IMNDKCGGPEH);
			PDEAHJPOMEF().SetVector("(scene)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 581f, 1316f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JILOMOBDPIA()
	{
	}

	private void COGBDFKOHKK()
	{
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
	}

	private void Start()
	{
	}

	private void KIMMMCJFMAB()
	{
	}

	private void KNBJBNDGCIJ()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CPCDFMMLHLO()
	{
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 866f)
			{
				HBJJOCHGOPH = 373f;
			}
			OIBHFCLJKDB().SetFloat("_Red_G", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("BadgeText", ALGIDJONBGN);
			KJMECMIGJJA().SetFloat("player.xp", IMNDKCGGPEH);
			HKIMAANBGMJ().SetVector("_Level", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1859f, 869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return BJFKDHHMLJH;
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 589f)
			{
				HBJJOCHGOPH = 809f;
			}
			HHLFDHNEIAH().SetFloat("D-Pad Left", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("GameScene", ALGIDJONBGN);
			HHIAIGCAHDA().SetFloat("curScn", IMNDKCGGPEH);
			BAGICADFBAB().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 771f, 396f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void DFFKKLAPHCC()
	{
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void LBAJLLFMMMP()
	{
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 388f)
			{
				HBJJOCHGOPH = 1796f;
			}
			MJJIEHANFJA().SetFloat("Horizontal", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("maps.", ALGIDJONBGN);
			OIIDAKBILMI().SetFloat("_TimeX", IMNDKCGGPEH);
			DIOAAHJDMLK().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 329f, 830f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMCKJCHKMKB()
	{
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
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
			if (HBJJOCHGOPH > 1096f)
			{
				HBJJOCHGOPH = 700f;
			}
			EMDFHOKEGNG().SetFloat("_Value2", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("_MatrixSize", ALGIDJONBGN);
			CIAFLBFJLEJ().SetFloat("_Value", IMNDKCGGPEH);
			KBOPGONOCNP().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 84f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1662f)
			{
				HBJJOCHGOPH = 1104f;
			}
			NBPKMLMCHFN.SetFloat("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("_Intensity", ALGIDJONBGN);
			KBOPGONOCNP().SetFloat("1332644700", IMNDKCGGPEH);
			DIOAAHJDMLK().SetVector("seconds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 676f, 253f));
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
			if (HBJJOCHGOPH > 876f)
			{
				HBJJOCHGOPH = 1330f;
			}
			BBIMPFGLDCP().SetFloat(".lastCheckpoint.correctScore", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("OxOD.lastPath", ALGIDJONBGN);
			KBOPGONOCNP().SetFloat("CameraFilterPack/AAA_Blood_Hit", IMNDKCGGPEH);
			BBIMPFGLDCP().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 33f, 777f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 938f)
			{
				HBJJOCHGOPH = 1788f;
			}
			EMDFHOKEGNG().SetFloat("offsets", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("Case-Sensitive", ALGIDJONBGN);
			HHIAIGCAHDA().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", IMNDKCGGPEH);
			LMLENGFLEBD().SetVector("settings.arcsdestroydelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1423f, 1601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void NKLIHNJCHOG()
	{
	}

	private void JECMJNFGBGC()
	{
	}

	private void HPFOFGJPNCI()
	{
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1045f)
			{
				HBJJOCHGOPH = 1822f;
			}
			LMLENGFLEBD().SetFloat("MascotChallenge2019", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_Offsets", ALGIDJONBGN);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Distortion_Flush", IMNDKCGGPEH);
			KBOPGONOCNP().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 434f, 523f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void KCCIEMBMOBA()
	{
	}

	private void DKGBFNCOAEO()
	{
	}

	private void IDIIELPAMCJ()
	{
	}

	private void EJFJENFKLND()
	{
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void KLILJHJNICK()
	{
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 752f)
			{
				HBJJOCHGOPH = 1098f;
			}
			BBIMPFGLDCP().SetFloat("SetSunMaxSize", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("_Value", ALGIDJONBGN);
			DIOAAHJDMLK().SetFloat("_CenterY", IMNDKCGGPEH);
			HHLFDHNEIAH().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 919f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
	}

	private void JBCNIPJDPJB()
	{
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 988f)
			{
				HBJJOCHGOPH = 1031f;
			}
			HKIMAANBGMJ().SetFloat("inventory.itemscash", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat(" .", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("[MapEditor] Prepairing map editor...", IMNDKCGGPEH);
			KBOPGONOCNP().SetVector("<b>#", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1321f, 1552f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IABLKKAALGI()
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1522f)
			{
				HBJJOCHGOPH = 1461f;
			}
			LMLENGFLEBD().SetFloat("CameraFilterPack/Distortion_Dream2", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("Hidden/DepthOfField/DepthOfField", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("Subscribed cells:\n", IMNDKCGGPEH);
			NLFJGMBCICG().SetVector("</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 658f, 608f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHLFDHNEIAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1460f)
			{
				HBJJOCHGOPH = 701f;
			}
			NLFJGMBCICG().SetFloat("Joystick1Button2", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("_Value2", ALGIDJONBGN);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Blend2Camera_Screen", IMNDKCGGPEH);
			MJJIEHANFJA().SetVector("#C8C8C8FF", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1072f, 840f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void HNGHDAPKEJG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMNPFCHBLJF()
	{
	}

	private void Update()
	{
	}
}
