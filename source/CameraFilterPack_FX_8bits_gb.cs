// CameraFilterPack_FX_8bits_gb
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Pixel/8bits_gb")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_8bits_gb : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(-1f, 1f)]
	public float Brightness;

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

	private void PKBENONAOOL()
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

	private void ONMGIPAILOH()
	{
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
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

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1482f)
			{
				HBJJOCHGOPH = 1787f;
			}
			IONHGBPGCHK().SetFloat("LobbyCanvas", HBJJOCHGOPH);
			if (Brightness == 1741f)
			{
				Brightness = 634f;
			}
			NBPKMLMCHFN.SetFloat("#", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-41, 153, 0);
			Graphics.Blit(AAACLELCPML, temporary, MMOODGIODPC());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("NetworkPeer broke!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 351f)
			{
				HBJJOCHGOPH = 1005f;
			}
			FHFLKLMFHOI().SetFloat("{0:x2}", HBJJOCHGOPH);
			if (Brightness == 1038f)
			{
				Brightness = 1286f;
			}
			HCGJCMDJPGD().SetFloat("en", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(65, 3, 1);
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1509f)
			{
				HBJJOCHGOPH = 361f;
			}
			NBPKMLMCHFN.SetFloat("turn", HBJJOCHGOPH);
			if (Brightness == 1667f)
			{
				Brightness = 1584f;
			}
			MMOODGIODPC().SetFloat("|", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(131, -1, 0);
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void CFIAKIJAILI()
	{
	}

	private void EHCGBJDFMHG()
	{
	}

	private void Update()
	{
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("Load Game");
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
			if (Brightness == 0f)
			{
				Brightness = 0.001f;
			}
			NBPKMLMCHFN.SetFloat("_Distortion", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(160, 144, 0);
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("FinalScoreSmallText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1090f)
			{
				HBJJOCHGOPH = 788f;
			}
			KBOPGONOCNP().SetFloat("CameraFilterPack/Vision_Warp", HBJJOCHGOPH);
			if (Brightness == 1791f)
			{
				Brightness = 1468f;
			}
			FHFLKLMFHOI().SetFloat("[Right-Down]", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-29, 111, 0);
			Graphics.Blit(AAACLELCPML, temporary, HCGJCMDJPGD());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1409f)
			{
				HBJJOCHGOPH = 725f;
			}
			IONHGBPGCHK().SetFloat("_Near", HBJJOCHGOPH);
			if (Brightness == 1344f)
			{
				Brightness = 1872f;
			}
			BFGNMFCNDBC().SetFloat("Items/", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(173, 134, 0);
			Graphics.Blit(AAACLELCPML, temporary, FHFLKLMFHOI());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("<color=#{0}>{1}</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_TileMaxOffs");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("_Red_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 681f)
			{
				HBJJOCHGOPH = 66f;
			}
			JIBOKBCPDLC().SetFloat("_Near", HBJJOCHGOPH);
			if (Brightness == 766f)
			{
				Brightness = 1945f;
			}
			EMDFHOKEGNG().SetFloat("_ScreenResolution", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(160, -159, 0);
			Graphics.Blit(AAACLELCPML, temporary, HCGJCMDJPGD());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 890f)
			{
				HBJJOCHGOPH = 1580f;
			}
			MMOODGIODPC().SetFloat("_SSAO", HBJJOCHGOPH);
			if (Brightness == 737f)
			{
				Brightness = 1511f;
			}
			MMOODGIODPC().SetFloat("int", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(125, 78, 1);
			Graphics.Blit(AAACLELCPML, temporary, MMOODGIODPC());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1388f)
			{
				HBJJOCHGOPH = 1559f;
			}
			KBOPGONOCNP().SetFloat(". Not connectedAndReady.", HBJJOCHGOPH);
			if (Brightness == 1695f)
			{
				Brightness = 1557f;
			}
			NBPKMLMCHFN.SetFloat("isVisible", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(166, -60, 0);
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_8bits_gb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHENLPJJOEN()
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
			if (HBJJOCHGOPH > 1200f)
			{
				HBJJOCHGOPH = 456f;
			}
			KAFBNOBOIAJ().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			if (Brightness == 650f)
			{
				Brightness = 1166f;
			}
			KBOPGONOCNP().SetFloat("SetCrosshairColor", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-62, -179, 0);
			Graphics.Blit(AAACLELCPML, temporary, EMDFHOKEGNG());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1838f)
			{
				HBJJOCHGOPH = 17f;
			}
			KBOPGONOCNP().SetFloat("CameraFilterPack/Distortion_Lens", HBJJOCHGOPH);
			if (Brightness == 120f)
			{
				Brightness = 551f;
			}
			FHFLKLMFHOI().SetFloat(",", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(11, -159, 0);
			Graphics.Blit(AAACLELCPML, temporary, JIBOKBCPDLC());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1742f)
			{
				HBJJOCHGOPH = 435f;
			}
			FHFLKLMFHOI().SetFloat("BitsData", HBJJOCHGOPH);
			if (Brightness == 53f)
			{
				Brightness = 1594f;
			}
			NBPKMLMCHFN.SetFloat("Vertical", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(92, -196, 0);
			Graphics.Blit(AAACLELCPML, temporary, FHFLKLMFHOI());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 298f)
			{
				HBJJOCHGOPH = 951f;
			}
			HCGJCMDJPGD().SetFloat("A", HBJJOCHGOPH);
			if (Brightness == 1162f)
			{
				Brightness = 1916f;
			}
			HCGJCMDJPGD().SetFloat("SetPlayerDistance", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-43, 88, 0);
			Graphics.Blit(AAACLELCPML, temporary, KBOPGONOCNP());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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
			if (HBJJOCHGOPH > 1084f)
			{
				HBJJOCHGOPH = 973f;
			}
			KBOPGONOCNP().SetFloat("_OffsetScale", HBJJOCHGOPH);
			if (Brightness == 296f)
			{
				Brightness = 520f;
			}
			MMOODGIODPC().SetFloat(".lastCheckpoint.isMapCompleted", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(15, 168, 0);
			Graphics.Blit(AAACLELCPML, temporary, BFGNMFCNDBC());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}
}
