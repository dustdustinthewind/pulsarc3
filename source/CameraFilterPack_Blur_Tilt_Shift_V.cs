// CameraFilterPack_Blur_Tilt_Shift_V
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Tilt_Shift_V")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Tilt_Shift_V : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	public float Amount = 3f;

	[Range(2f, 16f)]
	public int FastFilter = 8;

	[Range(0f, 1f)]
	public float Smooth = 0.5f;

	[Range(0f, 1f)]
	public float Size = 0.5f;

	[Range(-1f, 1f)]
	public float Position = 0.5f;

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

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GHILDCBCDJI()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1141f)
			{
				HBJJOCHGOPH = 1235f;
			}
			ADBKPGFMNKO().SetFloat("_Near", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Bullet_8", Amount);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Smooth);
			MMOODGIODPC().SetFloat("_LightIntensity", Size);
			NBPKMLMCHFN.SetFloat("<b><i>Map's Stats:</i></b>", Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 6);
				Graphics.Blit(temporary, temporary2, IIJMIPBMMBF(), 0);
				IIJMIPBMMBF().SetFloat("_MainTex2", Amount * 925f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 5);
				Graphics.Blit(temporary, temporary2, IIBLJCKLGFG(), 1);
				OIMMPLPBLBK().SetTexture("ShadersToggle", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAEGLMEOKHP()
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

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/BlurTiltShift_V");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1498f)
			{
				HBJJOCHGOPH = 824f;
			}
			IIBLJCKLGFG().SetFloat("UI Extensions/UIScreen", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Vision_Blood", Amount);
			ADBKPGFMNKO().SetFloat("float,1", Smooth);
			OIMMPLPBLBK().SetFloat("maps.", Size);
			IIJMIPBMMBF().SetFloat("_Value4", Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, IIJMIPBMMBF(), 8);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 1);
				IIJMIPBMMBF().SetFloat("float,0", Amount * 1692f);
				Graphics.Blit(temporary2, temporary, IIJMIPBMMBF(), 6);
				Graphics.Blit(temporary, temporary2, OIMMPLPBLBK(), 0);
				IIJMIPBMMBF().SetTexture("CameraFilterPack/TV_Old_Movie", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_TimeX");
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
			NBPKMLMCHFN.SetFloat("_Amount", Amount);
			NBPKMLMCHFN.SetFloat("_Value1", Smooth);
			NBPKMLMCHFN.SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetFloat("_Value3", Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("_Amount", Amount * 2f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetTexture("_MainTex2", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_DarkerColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find(" GameServer:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("SetSatelliteTrailWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 795f)
			{
				HBJJOCHGOPH = 643f;
			}
			NBPKMLMCHFN.SetFloat(";", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat(" ", Amount);
			OIMMPLPBLBK().SetFloat("{0}", Smooth);
			ADBKPGFMNKO().SetFloat("0.00", Size);
			ADBKPGFMNKO().SetFloat("_Intensity", Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, OIMMPLPBLBK(), 6);
				Graphics.Blit(temporary, temporary2, MMOODGIODPC(), 1);
				OIMMPLPBLBK().SetFloat("TestTicket", Amount * 1238f);
				Graphics.Blit(temporary2, temporary, OIMMPLPBLBK(), 5);
				Graphics.Blit(temporary, temporary2, IIBLJCKLGFG(), 1);
				IIBLJCKLGFG().SetTexture("/music", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("shader.invert");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1438f)
			{
				HBJJOCHGOPH = 288f;
			}
			ADBKPGFMNKO().SetFloat("[LocalizationService] Localization: ", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("SetSatelliteLerpSpeed", Amount);
			OIMMPLPBLBK().SetFloat("_Value1", Smooth);
			NBPKMLMCHFN.SetFloat("_Value3", Size);
			NBPKMLMCHFN.SetFloat("No", Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, MMOODGIODPC(), 5);
				Graphics.Blit(temporary, temporary2, IIBLJCKLGFG(), 1);
				IIBLJCKLGFG().SetFloat("SupportLogger OnDisconnectedFromPhoton().", Amount * 523f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 5);
				Graphics.Blit(temporary, temporary2, IIJMIPBMMBF(), 1);
				OIMMPLPBLBK().SetTexture("DPADHOR", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1054f)
			{
				HBJJOCHGOPH = 211f;
			}
			OIMMPLPBLBK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("yes", Amount);
			OIMMPLPBLBK().SetFloat("[PlayerController] ", Smooth);
			ADBKPGFMNKO().SetFloat(" Remote called.", Size);
			MMOODGIODPC().SetFloat("_BlurDirectionPacked", Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, IIBLJCKLGFG(), 5);
				Graphics.Blit(temporary, temporary2, IIBLJCKLGFG(), 0);
				NBPKMLMCHFN.SetFloat("CameraFilterPack_Atmosphere_Rain_FX", Amount * 601f);
				Graphics.Blit(temporary2, temporary, OIMMPLPBLBK(), 1);
				Graphics.Blit(temporary, temporary2, IIBLJCKLGFG(), 0);
				NBPKMLMCHFN.SetTexture(" key(s)", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1818f)
			{
				HBJJOCHGOPH = 1380f;
			}
			OIMMPLPBLBK().SetFloat("Set Particles Color", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Blue_B", Amount);
			NBPKMLMCHFN.SetFloat("_ColorBuffer", Smooth);
			IIJMIPBMMBF().SetFloat("SetSatelliteTrailWidth", Size);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Oculus_NightVision2", Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, MMOODGIODPC(), 7);
				Graphics.Blit(temporary, temporary2, OIMMPLPBLBK(), 0);
				NBPKMLMCHFN.SetFloat("mapselector.filter.subscribedonly", Amount * 449f);
				Graphics.Blit(temporary2, temporary, IIJMIPBMMBF(), 8);
				Graphics.Blit(temporary, temporary2, ADBKPGFMNKO(), 1);
				ADBKPGFMNKO().SetTexture("x", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
