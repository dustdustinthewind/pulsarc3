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
			BAGICADFBAB().SetFloat("_SpherePositionY", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("[LevelEditorScene] Map submitted!", ALGIDJONBGN);
			DBOLLHHMKKN().SetFloat(".g", IMNDKCGGPEH);
			BBIMPFGLDCP().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 295f, 818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			OIBHFCLJKDB().SetFloat("#ok", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Antialiasing_FXAA", ALGIDJONBGN);
			HHLFDHNEIAH().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", IMNDKCGGPEH);
			LMLENGFLEBD().SetVector("Text", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 115f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			OIIDAKBILMI().SetFloat("player.mysteryitem", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("CameraFilterPack/FX_Grid", ALGIDJONBGN);
			BAGICADFBAB().SetFloat("#forever", IMNDKCGGPEH);
			PDEAHJPOMEF().SetVector("float,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 602f, 720f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			KBOPGONOCNP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("SpawnObj", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("_TimeX", IMNDKCGGPEH);
			KJMECMIGJJA().SetVector("Failed to 'GetKeyCode' for key: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 101f, 1173f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			CFEDGDGBCHE().SetFloat("achievements.21.completed.workshop.", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", ALGIDJONBGN);
			BBIMPFGLDCP().SetFloat("/", IMNDKCGGPEH);
			CFEDGDGBCHE().SetVector("finished", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 363f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			OIBHFCLJKDB().SetFloat("menu.tabid", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Can't do manual instantiation without PhotonView component.", ALGIDJONBGN);
			LMLENGFLEBD().SetFloat("settings.volume.editor", IMNDKCGGPEH);
			DIOAAHJDMLK().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 533f, 247f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			HHIAIGCAHDA().SetFloat("_TimeX", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("Beat Detected", IMNDKCGGPEH);
			OIIDAKBILMI().SetVector("/icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 57f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			BAGICADFBAB().SetFloat("EnableRankedNotificationsToggle", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", ALGIDJONBGN);
			CIAFLBFJLEJ().SetFloat("OK", IMNDKCGGPEH);
			LMLENGFLEBD().SetVector("_Speed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 106f, 112f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			CFEDGDGBCHE().SetFloat("The given 2D texture ", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("fade in duration", ALGIDJONBGN);
			DIOAAHJDMLK().SetFloat("_Green_R", IMNDKCGGPEH);
			OIIDAKBILMI().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 838f, 1561f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			HHIAIGCAHDA().SetFloat("Editor", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("maps.", ALGIDJONBGN);
			NBPKMLMCHFN.SetFloat("\t", IMNDKCGGPEH);
			BBIMPFGLDCP().SetVector("set id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 898f, 600f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			EJDPNJAEAKJ().SetFloat("Rotate environment object to the rotation", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("(\\[ *quote *\\])", ALGIDJONBGN);
			DIOAAHJDMLK().SetFloat("[LocalizationService] All keys for ", IMNDKCGGPEH);
			KJMECMIGJJA().SetVector("RB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 518f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
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
			OIBHFCLJKDB().SetFloat("IncorrectHitsScoreText", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("_Value1", ALGIDJONBGN);
			OIIDAKBILMI().SetFloat("DPADVER", IMNDKCGGPEH);
			DIOAAHJDMLK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 844f, 1261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			NBPKMLMCHFN.SetFloat("_Value2", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_MainTex2", ALGIDJONBGN);
			DBOLLHHMKKN().SetFloat("_Value6", IMNDKCGGPEH);
			BAGICADFBAB().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 475f, 1184f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
			MJJIEHANFJA().SetFloat("_Value12", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("player.orangelifering", ALGIDJONBGN);
			BAGICADFBAB().SetFloat("_MainTex2", IMNDKCGGPEH);
			PDEAHJPOMEF().SetVector(" Mb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1758f, 332f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			BBIMPFGLDCP().SetFloat("Right Click", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("_TimeX", ALGIDJONBGN);
			HHIAIGCAHDA().SetFloat("win", IMNDKCGGPEH);
			NLFJGMBCICG().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1151f, 884f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			NLFJGMBCICG().SetFloat("shader.pixel", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("_MainTex", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", IMNDKCGGPEH);
			HKIMAANBGMJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 930f, 12f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			BAGICADFBAB().SetFloat("error", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("_MinVelocity", ALGIDJONBGN);
			CFEDGDGBCHE().SetFloat("[PlayerBase] New highscore", IMNDKCGGPEH);
			BAGICADFBAB().SetVector(".lastCheckpoint.lives", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 382f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
			DBOLLHHMKKN().SetFloat("_ArScale", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat("Lerp speed. Recomended 10", ALGIDJONBGN);
			OIBHFCLJKDB().SetFloat("Right Stick Click", IMNDKCGGPEH);
			OIIDAKBILMI().SetVector("BestRegion checks region: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 581f, 1316f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			CFEDGDGBCHE().SetFloat("_Red_B", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("BadgeText", ALGIDJONBGN);
			KBOPGONOCNP().SetFloat("player.gamecompleted", IMNDKCGGPEH);
			EJDPNJAEAKJ().SetVector("_Distance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1859f, 869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
			NLFJGMBCICG().SetFloat("settings_bindings_", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("GameScene", ALGIDJONBGN);
			EJDPNJAEAKJ().SetFloat("Parameter levelId must be int or string!", IMNDKCGGPEH);
			MJJIEHANFJA().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 771f, 396f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			OIIDAKBILMI().SetFloat("Submit", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("[GameEvent] Exeption:", ALGIDJONBGN);
			LMLENGFLEBD().SetFloat("_Value", IMNDKCGGPEH);
			PDEAHJPOMEF().SetVector(".lastCheckpoint.maxLongestCombo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 329f, 830f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
			CFEDGDGBCHE().SetFloat("_Value2", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_MatrixSize", ALGIDJONBGN);
			OIIDAKBILMI().SetFloat("_Value2", IMNDKCGGPEH);
			LMLENGFLEBD().SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 84f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			PDEAHJPOMEF().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("_Intensity", ALGIDJONBGN);
			HHIAIGCAHDA().SetFloat("achievements.21.completed.workshop.", IMNDKCGGPEH);
			EMDFHOKEGNG().SetVector("seconds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 676f, 253f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			HHLFDHNEIAH().SetFloat("maps.", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("#.##", ALGIDJONBGN);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/AAA_Blood_Hit", IMNDKCGGPEH);
			KBOPGONOCNP().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 33f, 777f));
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
			NBPKMLMCHFN.SetFloat("offsets", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("Case-Sensitive", ALGIDJONBGN);
			PDEAHJPOMEF().SetFloat("GameScene", IMNDKCGGPEH);
			DIOAAHJDMLK().SetVector("settings.arcsdestroydelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1423f, 1601f));
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
			BAGICADFBAB().SetFloat("arcs", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_BlurredColor", ALGIDJONBGN);
			CIAFLBFJLEJ().SetFloat("_TimeX", IMNDKCGGPEH);
			NLFJGMBCICG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 434f, 523f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
			KBOPGONOCNP().SetFloat("Set Sun MaxSize", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_Value2", ALGIDJONBGN);
			CFEDGDGBCHE().SetFloat("_CenterY", IMNDKCGGPEH);
			BBIMPFGLDCP().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 919f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
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
			OIBHFCLJKDB().SetFloat("|", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("PunSupportLogger", ALGIDJONBGN);
			EMDFHOKEGNG().SetFloat("[MapEditor] Loading music...", IMNDKCGGPEH);
			HHLFDHNEIAH().SetVector("received</b>\n#reason: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1321f, 1552f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			CFEDGDGBCHE().SetFloat("_TimeX", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("Hidden/DepthOfField/BokehSplatting", ALGIDJONBGN);
			MJJIEHANFJA().SetFloat(" | ", IMNDKCGGPEH);
			CFEDGDGBCHE().SetVector("RPC: 'OnAwakeRPC' PhotonView: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 658f, 608f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
			EJDPNJAEAKJ().SetFloat("B", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value2", ALGIDJONBGN);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Screen", IMNDKCGGPEH);
			OIIDAKBILMI().SetVector("RecordButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1072f, 840f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
