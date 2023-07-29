// CameraFilterPack_Blur_Movie
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Movie")]
[ExecuteInEditMode]
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
			LONNIJMNKFB().SetFloat("_Fade", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("#exit", Radius / (float)fastFilter);
			DBOLLHHMKKN().SetFloat("LoadingStatusText", Factor);
			DOHGBNPMBKG().SetVector("ShowSprite", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN());
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
		SCShader = Shader.Find("/");
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
			JIBOKBCPDLC().SetFloat("GlassDistortion", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("[EMPTY]", Radius / (float)fastFilter);
			JIBOKBCPDLC().SetFloat(" Mb", Factor);
			DBOLLHHMKKN().SetVector("settings.hitvariation", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_ToPrevViewProjCombined");
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
			EPCGJFCCAFH().SetFloat("_Size", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_History1LumaTex", Radius / (float)fastFilter);
			FAIFBBGFAIB().SetFloat("Print the list of scenes, avalable in game.", Factor);
			DOHGBNPMBKG().SetVector("workshop.", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
			DOHGBNPMBKG().SetFloat("sfxVolume", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_Color", Radius / (float)fastFilter);
			DBOLLHHMKKN().SetFloat("_Value", Factor);
			DBOLLHHMKKN().SetVector("My New Mod Pack", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
		SCShader = Shader.Find("_RangeScale");
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
			NBPKMLMCHFN.SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Noise", Radius / (float)fastFilter);
			DOHGBNPMBKG().SetFloat("_MainTex2", Factor);
			DBOLLHHMKKN().SetVector("_Value4", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
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
			DBOLLHHMKKN().SetFloat("_Threshhold", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("MapEnd", Radius / (float)fastFilter);
			FAIFBBGFAIB().SetFloat("[PlayerBase] Saveing checkpoint data", Factor);
			AELJLBOJAIL().SetVector("_TimeX", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
		SCShader = Shader.Find("_TimeX");
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
			NBPKMLMCHFN.SetFloat("Lerp speed. Recomended 10", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat(".", Radius / (float)fastFilter);
			EPCGJFCCAFH().SetFloat("float,10", Factor);
			DOHGBNPMBKG().SetVector("Editor/", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
		SCShader = Shader.Find("B");
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
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("0.00", Radius / (float)fastFilter);
			AELJLBOJAIL().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", Factor);
			JIBOKBCPDLC().SetVector(".", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
			AELJLBOJAIL().SetFloat("difficulty", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Finished", Radius / (float)fastFilter);
			DOHGBNPMBKG().SetFloat("HH:mm:ss", Factor);
			DBOLLHHMKKN().SetVector("_TimeX", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
			JIBOKBCPDLC().SetFloat("_Value4", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("[MapEditor] Loading music...", Radius / (float)fastFilter);
			EPCGJFCCAFH().SetFloat("0,2,true,0", Factor);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
			NBPKMLMCHFN.SetFloat("Texture2", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat(" Loaded: ", Radius / (float)fastFilter);
			AELJLBOJAIL().SetFloat("float,1.5", Factor);
			DBOLLHHMKKN().SetVector("_DiffuseColor", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, DOHGBNPMBKG());
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
