// CameraFilterPack_Blur_Movie
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/Movie")]
public class CameraFilterPack_Blur_Movie : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1000f)]
	public float Radius = 150f;

	[Range(0f, 1000f)]
	public float Factor = 200f;

	[Range(1f, 8f)]
	public int FastFilter = 2;

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

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Movie");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 303f)
			{
				HBJJOCHGOPH = 1464f;
			}
			FAIFBBGFAIB().SetFloat("_TimeX", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("#tryagain", Radius / (float)fastFilter);
			DOHGBNPMBKG().SetFloat("Loading inventory", Factor);
			NBPKMLMCHFN.SetVector("SpawnObj", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, JIBOKBCPDLC());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1447f)
			{
				HBJJOCHGOPH = 1011f;
			}
			JIBOKBCPDLC().SetFloat("VisionBlur", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("[ERROR KEY {0}]", Radius / (float)fastFilter);
			NBPKMLMCHFN.SetFloat("1 Kb", Factor);
			JIBOKBCPDLC().SetVector("settings.enableselectormusic", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_TileTexDebug");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1474f)
			{
				HBJJOCHGOPH = 991f;
			}
			NBPKMLMCHFN.SetFloat("_Color_B", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_VelocityTex", Radius / (float)fastFilter);
			EPCGJFCCAFH().SetFloat("< true | false >", Factor);
			JIBOKBCPDLC().SetVector("MapperNameText", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, FAIFBBGFAIB());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1028f)
			{
				HBJJOCHGOPH = 1726f;
			}
			EPCGJFCCAFH().SetFloat("menuVolume", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("BlockCount", Radius / (float)fastFilter);
			EPCGJFCCAFH().SetFloat("_TimeX", Factor);
			FAIFBBGFAIB().SetVector(" - ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, FAIFBBGFAIB());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("resource");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBNPEHMDCMI()
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
		SCShader = Shader.Find("_BlurArea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1358f)
			{
				HBJJOCHGOPH = 1486f;
			}
			FAIFBBGFAIB().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_Distortion", Radius / (float)fastFilter);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", Factor);
			AELJLBOJAIL().SetVector("_Value3", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1397f)
			{
				HBJJOCHGOPH = 1409f;
			}
			DOHGBNPMBKG().SetFloat("colorD", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("menu.playedsolo", Radius / (float)fastFilter);
			EPCGJFCCAFH().SetFloat("FinishMap", Factor);
			DOHGBNPMBKG().SetVector("CameraFilterPack/Fly_Vision", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
			}
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

	private void AIJGAJIOJDJ()
	{
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Dithering2x2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1596f)
			{
				HBJJOCHGOPH = 386f;
			}
			DOHGBNPMBKG().SetFloat("speed", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("maps.", Radius / (float)fastFilter);
			AELJLBOJAIL().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", Factor);
			DBOLLHHMKKN().SetVector("/", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, JIBOKBCPDLC());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
			}
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("A");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Radius", Radius / (float)fastFilter);
			NBPKMLMCHFN.SetFloat("_Factor", Factor);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void KMKLDAJLCNM()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1606f)
			{
				HBJJOCHGOPH = 1804f;
			}
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("CurrentTimeLabel", Radius / (float)fastFilter);
			JIBOKBCPDLC().SetFloat("arcs", Factor);
			EPCGJFCCAFH().SetVector(".", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
			}
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

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 74f)
			{
				HBJJOCHGOPH = 719f;
			}
			DOHGBNPMBKG().SetFloat("maphash", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("OnPlayerGameMessage", Radius / (float)fastFilter);
			AELJLBOJAIL().SetFloat("[", Factor);
			FAIFBBGFAIB().SetVector("CameraFilterPack/Atmosphere_Rain", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, JIBOKBCPDLC());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
			}
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
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1993f)
			{
				HBJJOCHGOPH = 378f;
			}
			DBOLLHHMKKN().SetFloat("_Value3", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("[MapEditor] Prepairing map editor...", Radius / (float)fastFilter);
			DBOLLHHMKKN().SetFloat("0,2,true,0", Factor);
			DBOLLHHMKKN().SetVector("_Colored", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 327f)
			{
				HBJJOCHGOPH = 1267f;
			}
			EPCGJFCCAFH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" Path: ", Radius / (float)fastFilter);
			FAIFBBGFAIB().SetFloat("value", Factor);
			DOHGBNPMBKG().SetVector("ShowTitle", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
			}
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}
}
