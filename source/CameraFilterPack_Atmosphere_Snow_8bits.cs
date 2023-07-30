// CameraFilterPack_Atmosphere_Snow_8bits
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Pixel/Snow_8bits")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Snow_8bits : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.9f, 2f)]
	public float Threshold = 1f;

	[Range(8f, 256f)]
	public float Size = 64f;

	[Range(-0.5f, 0.5f)]
	public float DirectionX;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void AEIJFLJEABG()
	{
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 911f)
			{
				HBJJOCHGOPH = 1319f;
			}
			DBOLLHHMKKN().SetFloat("_ReflectionTexture2", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("UI Extensions/UIScreen", Threshold);
			OIMMPLPBLBK().SetFloat(" ", Size);
			GCDFNHMJMIP().SetFloat("_Value", DirectionX);
			EOCCJGIGEGJ().SetFloat("Menu", Fade);
			FLOHGDECHHH().SetVector("UndoButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 637f, 918f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 230f)
			{
				HBJJOCHGOPH = 6f;
			}
			MCDGIILBNIF().SetFloat("_FarCamera", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("settings.hitvariation", Threshold);
			KGOLDDBHIFN().SetFloat("float,10", Size);
			NFMGLIKNOOC().SetFloat("_Visualize", DirectionX);
			EOCCJGIGEGJ().SetFloat("menu.selectedlevelid", Fade);
			NBPKMLMCHFN.SetVector(" not found", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 927f, 1534f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("player.bluebat");
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
			if (HBJJOCHGOPH > 449f)
			{
				HBJJOCHGOPH = 1702f;
			}
			GJHLADDCMFF().SetFloat("Uploading content", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("<size=24>", Threshold);
			DBOLLHHMKKN().SetFloat(":", Size);
			KGOLDDBHIFN().SetFloat("/Saved Games/", DirectionX);
			KGOLDDBHIFN().SetFloat("Tab2Content", Fade);
			MICHFGAOPKM().SetVector("[MapEditor] Loading events...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 158f, 909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void JOACBIEHHCE()
	{
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
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
			NBPKMLMCHFN.SetFloat("_Value", Threshold);
			NBPKMLMCHFN.SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetFloat("_Value3", DirectionX);
			NBPKMLMCHFN.SetFloat("_Value4", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			if (HBJJOCHGOPH > 1521f)
			{
				HBJJOCHGOPH = 248f;
			}
			MCDGIILBNIF().SetFloat("GlassesColor", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("The other scroll rect doesnt support scrolling vertically", Threshold);
			NFMGLIKNOOC().SetFloat(") then the masterserver requests a disconnect!", Size);
			MCDGIILBNIF().SetFloat("_TimeX", DirectionX);
			KGOLDDBHIFN().SetFloat("In Map Editor", Fade);
			EOCCJGIGEGJ().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 205f, 32f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMOCDAOKGLI()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1280f)
			{
				HBJJOCHGOPH = 1653f;
			}
			MCDGIILBNIF().SetFloat("y", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Glitch", Threshold);
			PDEAHJPOMEF().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", Size);
			NFMGLIKNOOC().SetFloat("[RanksSystem] Ranks updated. Next update: ", DirectionX);
			OKJOKHGJHGF().SetFloat("challenges.", Fade);
			OIMMPLPBLBK().SetVector("NameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1495f, 1818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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

	private void EHCGBJDFMHG()
	{
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJFJENFKLND()
	{
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 698f)
			{
				HBJJOCHGOPH = 433f;
			}
			MICHFGAOPKM().SetFloat("ControllerRightY", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("MenuScene", Threshold);
			OKJOKHGJHGF().SetFloat("_Level", Size);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", DirectionX);
			MCDGIILBNIF().SetFloat("_Shadow", Fade);
			NBPKMLMCHFN.SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1062f, 1609f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJIKDJAMOHA()
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

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("points:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 835f)
			{
				HBJJOCHGOPH = 1017f;
			}
			NBPKMLMCHFN.SetFloat("_Dist", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("0.00", Threshold);
			OIMMPLPBLBK().SetFloat("MultiplayerButton", Size);
			ADBKPGFMNKO().SetFloat("_BlurredColor", DirectionX);
			OIMMPLPBLBK().SetFloat("UseFinalGlassColor", Fade);
			KGOLDDBHIFN().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 692f, 529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Atmosphere_Snow_8bits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("GlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1580f)
			{
				HBJJOCHGOPH = 428f;
			}
			MCDGIILBNIF().SetFloat("_HrDepthTex", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("sprite", Threshold);
			EOCCJGIGEGJ().SetFloat("/?player=", Size);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack_3D_Myst1", DirectionX);
			BFGNMFCNDBC().SetFloat("_Red_G", Fade);
			NBPKMLMCHFN.SetVector("LastHighScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1849f, 732f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
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

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1561f)
			{
				HBJJOCHGOPH = 153f;
			}
			DBOLLHHMKKN().SetFloat("_Green_C", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("settings_bindings_", Threshold);
			PDEAHJPOMEF().SetFloat("tagElement", Size);
			NFMGLIKNOOC().SetFloat("Tab1Content", DirectionX);
			OKJOKHGJHGF().SetFloat("GlassDistortion", Fade);
			GJHLADDCMFF().SetVector("+", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1806f, 1564f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("RemoveEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("[NetworkManager] Connecting...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1927f)
			{
				HBJJOCHGOPH = 798f;
			}
			MCDGIILBNIF().SetFloat("z", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(" in-game items", Threshold);
			OIMMPLPBLBK().SetFloat("================================", Size);
			OIMMPLPBLBK().SetFloat("_Amount", DirectionX);
			GJHLADDCMFF().SetFloat(" BETA", Fade);
			DBOLLHHMKKN().SetVector("steamid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 388f, 1653f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}
}
