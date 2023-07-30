// CameraFilterPack_FX_Screens
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Screens")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Screens : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 256f)]
	public float Tiles = 8f;

	[Range(0f, 5f)]
	public float Speed = 0.25f;

	public Color color = new Color(0f, 1f, 1f, 1f);

	[Range(-1f, 1f)]
	public float PosX;

	[Range(-1f, 1f)]
	public float PosY;

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

	private void PKHPNHBEKHA()
	{
	}

	private void AEEGKLABFLN()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1717f)
			{
				HBJJOCHGOPH = 946f;
			}
			BFGNMFCNDBC().SetFloat("_Value4", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("false", Tiles);
			DKKBFFHBHJE().SetFloat("GlassesColor", Speed);
			PHGCJOPFDOG().SetFloat("id", PosX);
			CIAFLBFJLEJ().SetFloat("#FFFFFFFF", PosY);
			OIIDAKBILMI().SetColor("OneHand", color);
			LPMLLJKMAMP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1637f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("[NetworkManager] Updating rooms...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("_HueShift");
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

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("OnPickedUp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 464f)
			{
				HBJJOCHGOPH = 661f;
			}
			MJJIEHANFJA().SetFloat("_TimeX", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("maps.", Tiles);
			DEFBJOCJJKF().SetFloat("???", Speed);
			HKHBBBFLGJH().SetFloat("_Value2", PosX);
			BKKJJJGADLM().SetFloat("#random #epic #item", PosY);
			DKKBFFHBHJE().SetColor("\" for viewID ", color);
			EPCGJFCCAFH().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1068f, 1629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("AmbientOcclusion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1914f)
			{
				HBJJOCHGOPH = 1631f;
			}
			OIIDAKBILMI().SetFloat("_Value2", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("]", Tiles);
			NJDIODJNGGA().SetFloat("[PlayerController] ", Speed);
			OIIDAKBILMI().SetFloat("Mouse X", PosX);
			PHGCJOPFDOG().SetFloat("CompletedLevel", PosY);
			KAFBNOBOIAJ().SetColor("menu.enableselectormusic", color);
			OLHDPICFBOF().SetVector("\t", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1009f)
			{
				HBJJOCHGOPH = 163f;
			}
			LPMLLJKMAMP().SetFloat("ShowTitle", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_SceneFogMode", Tiles);
			FHFLKLMFHOI().SetFloat("_Value4", Speed);
			EPCGJFCCAFH().SetFloat("SupportLogger OnFailedToConnectToPhoton(", PosX);
			HKGAONMOBMH().SetFloat("player.xp", PosY);
			KAFBNOBOIAJ().SetColor("_CenterY", color);
			HHIAIGCAHDA().SetVector("AvatarImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1979f, 555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1948f)
			{
				HBJJOCHGOPH = 1684f;
			}
			FHFLKLMFHOI().SetFloat("There is already a virtual button named ", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Value6", Tiles);
			DEFBJOCJJKF().SetFloat("_TimeX", Speed);
			NBPKMLMCHFN.SetFloat("_SmoothStart", PosX);
			HKHBBBFLGJH().SetFloat("ItemNameText", PosY);
			HHIAIGCAHDA().SetColor("<b>", color);
			DKKBFFHBHJE().SetVector("cmd.exe", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 578f, 390f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDJEJBBDILE()
	{
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
			NBPKMLMCHFN.SetFloat("_Value", Tiles);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			NBPKMLMCHFN.SetFloat("_Value3", PosX);
			NBPKMLMCHFN.SetFloat("_Value4", PosY);
			NBPKMLMCHFN.SetColor("_color", color);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 699f)
			{
				HBJJOCHGOPH = 1652f;
			}
			KAFBNOBOIAJ().SetFloat("settings.volume.editor", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Freq: ", Tiles);
			KEMAALEODNH().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", Speed);
			CIAFLBFJLEJ().SetFloat("skin.", PosX);
			ABHDNGIHBKE().SetFloat("Metal", PosY);
			LPMLLJKMAMP().SetColor("z", color);
			FHFLKLMFHOI().SetVector("_CenterX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1782f, 1700f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("Case-Sensitive");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 2f)
			{
				HBJJOCHGOPH = 75f;
			}
			PHGCJOPFDOG().SetFloat("3;4;9;10;21x6", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat(",", Tiles);
			OLHDPICFBOF().SetFloat("_ScreenResolution", Speed);
			DKKBFFHBHJE().SetFloat("_Value3", PosX);
			LPMLLJKMAMP().SetFloat("SpawnObj", PosY);
			NJDIODJNGGA().SetColor("1", color);
			HEINDEMCGIK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1686f, 470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 110f)
			{
				HBJJOCHGOPH = 761f;
			}
			EPCGJFCCAFH().SetFloat("masterSteamID", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Value4", Tiles);
			DNLMFEGJJDD().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", Speed);
			FHFLKLMFHOI().SetFloat(" while connecting to: ", PosX);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/FX_Hexagon", PosY);
			OLHDPICFBOF().SetColor("/", color);
			BKKJJJGADLM().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1574f, 1800f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("https://bitbucket.org/khb-soft/intralismarcsviewer/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 308f)
			{
				HBJJOCHGOPH = 1749f;
			}
			PHGCJOPFDOG().SetFloat("Y", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("SettingsCanvas", Tiles);
			KEMAALEODNH().SetFloat("No peer to communicate with. ", Speed);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/TV_CompressionFX", PosX);
			HKHBBBFLGJH().SetFloat("couldn't be found!", PosY);
			EOCCJGIGEGJ().SetColor("Xbox Home", color);
			PHGCJOPFDOG().SetVector("PickupItemInit", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1556f, 1787f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
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

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find(".GoalProgress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1226f)
			{
				HBJJOCHGOPH = 1751f;
			}
			KAFBNOBOIAJ().SetFloat("_Value7", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("[MapsSystem] Unloading maps resources...", Tiles);
			BKKJJJGADLM().SetFloat("Coroutine container not configured... did you forget to call Init?", Speed);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", PosX);
			DEFBJOCJJKF().SetFloat("[MapsData] Caching ", PosY);
			DEFBJOCJJKF().SetColor("tolobby", color);
			BKKJJJGADLM().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1727f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("en");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 418f)
			{
				HBJJOCHGOPH = 797f;
			}
			OLHDPICFBOF().SetFloat("Indie", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat(" Time: ", Tiles);
			PDEAHJPOMEF().SetFloat("_CurTex", Speed);
			NJDIODJNGGA().SetFloat("Set Sun Input", PosX);
			PHGCJOPFDOG().SetFloat("Switch environment sprite image", PosY);
			FHFLKLMFHOI().SetColor("settings.cameramovements", color);
			NBPKMLMCHFN.SetVector("Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 437f, 469f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1360f)
			{
				HBJJOCHGOPH = 1301f;
			}
			LPMLLJKMAMP().SetFloat("_Blue_C", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("PointerEnter ", Tiles);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			FAIFBBGFAIB().SetFloat("Set particless emission (glow)", PosX);
			MJJIEHANFJA().SetFloat("0 - default, 1 - left, 2 - right", PosY);
			BFGNMFCNDBC().SetColor("Connection error: ", color);
			NJDIODJNGGA().SetVector("challenges/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 281f, 825f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void NDAJBJFJGCF()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1259f)
			{
				HBJJOCHGOPH = 1737f;
			}
			DKKBFFHBHJE().SetFloat("COMPLETED", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_NoiseScale", Tiles);
			HNFFHCLNBDN().SetFloat("original.tutorial", Speed);
			PHGCJOPFDOG().SetFloat("Need to specify a start index and end index.", PosX);
			BFGNMFCNDBC().SetFloat("Set Trail Zoom Speed", PosY);
			DEFBJOCJJKF().SetColor("[Down]", color);
			OLHDPICFBOF().SetVector("HightScoreMaxPointsText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1307f, 1688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("Floating point textures aren't supported on this device ({0})");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 550f)
			{
				HBJJOCHGOPH = 565f;
			}
			HEINDEMCGIK().SetFloat("plainText", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_AlphaHexa", Tiles);
			BKKJJJGADLM().SetFloat("CameraFilterPack/Gradients_Ansi", Speed);
			OIIDAKBILMI().SetFloat("_DistanceParams", PosX);
			EPCGJFCCAFH().SetFloat("challenges.", PosY);
			BFGNMFCNDBC().SetColor(" : ", color);
			EPCGJFCCAFH().SetVector("editor.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 589f, 586f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("Ev OwnershipRequest ");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 406f)
			{
				HBJJOCHGOPH = 134f;
			}
			BKKJJJGADLM().SetFloat("/", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_TapMedium", Tiles);
			NJDIODJNGGA().SetFloat("_Offsets", Speed);
			KEMAALEODNH().SetFloat("value", PosX);
			HEINDEMCGIK().SetFloat("CameraFilterPack_Glasses_On3", PosY);
			NBPKMLMCHFN.SetColor("Keypad", color);
			EPCGJFCCAFH().SetVector("EventData0DropDownList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1427f, 1337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
			if (HBJJOCHGOPH > 53f)
			{
				HBJJOCHGOPH = 1317f;
			}
			PDEAHJPOMEF().SetFloat("bad", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("LevelEditor/icons", Tiles);
			CIAFLBFJLEJ().SetFloat("VIGNETTE_BLUR", Speed);
			DKNJGHFLAIF().SetFloat(": ", PosX);
			BFGNMFCNDBC().SetFloat("_Intensity", PosY);
			PDEAHJPOMEF().SetColor("_ScreenResolution", color);
			LPMLLJKMAMP().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1073f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find(" in SaveLoadMenu.prefabDictionary!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1608f)
			{
				HBJJOCHGOPH = 1112f;
			}
			LPMLLJKMAMP().SetFloat("_VelocityTex", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_Intervale", Tiles);
			EOCCJGIGEGJ().SetFloat("settings.shaders", Speed);
			HNFFHCLNBDN().SetFloat("Editor", PosX);
			DKNJGHFLAIF().SetFloat("Committing changes...", PosY);
			NJDIODJNGGA().SetColor("SetSunMaxSize", color);
			BKKJJJGADLM().SetVector("_Threshhold", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 477f, 603f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			if (HBJJOCHGOPH > 1584f)
			{
				HBJJOCHGOPH = 168f;
			}
			DEFBJOCJJKF().SetFloat("z", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat(".lastCheckpoint.incorrectScore", Tiles);
			DKNJGHFLAIF().SetFloat("[Right]", Speed);
			KEMAALEODNH().SetFloat("ERROR: preview file name is empty in modName.workshop.json", PosX);
			HHIAIGCAHDA().SetFloat("#close", PosY);
			OIIDAKBILMI().SetColor("_Value4", color);
			FAIFBBGFAIB().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1351f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1834f)
			{
				HBJJOCHGOPH = 1096f;
			}
			HKGAONMOBMH().SetFloat("CameraFilterPack/Pixel_Pixelisation", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("CameraFilterPack/TV_MovieNoise", Tiles);
			EPCGJFCCAFH().SetFloat("settings.volume.editor", Speed);
			BKKJJJGADLM().SetFloat("Tab1Content", PosX);
			OIIDAKBILMI().SetFloat("Connected to gameserver.", PosY);
			DEFBJOCJJKF().SetColor("Items", color);
			DEFBJOCJJKF().SetVector("Ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1845f, 362f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1979f)
			{
				HBJJOCHGOPH = 627f;
			}
			NBPKMLMCHFN.SetFloat("[MapsData] Workshop maps was loaded", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("[LocalizationService] Loading file: ", Tiles);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/FX_Hypno", Speed);
			FAIFBBGFAIB().SetFloat("_Value2", PosX);
			DNLMFEGJJDD().SetFloat("Triangle", PosY);
			HKHBBBFLGJH().SetColor("float,0", color);
			PDEAHJPOMEF().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 58f, 1209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCCGJMPAJIK()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 127f)
			{
				HBJJOCHGOPH = 10f;
			}
			FHFLKLMFHOI().SetFloat("_TimeX", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("_ReflectionTexture1", Tiles);
			HEINDEMCGIK().SetFloat("00", Speed);
			HHIAIGCAHDA().SetFloat("gold", PosX);
			BFGNMFCNDBC().SetFloat("<b><i>Map's Stats:</i></b>", PosY);
			HKGAONMOBMH().SetColor(" ; ", color);
			DKKBFFHBHJE().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 750f, 383f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 424f)
			{
				HBJJOCHGOPH = 51f;
			}
			HNFFHCLNBDN().SetFloat("_TimeX", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat(" By: ", Tiles);
			HKGAONMOBMH().SetFloat("_LightIntensity", Speed);
			CIAFLBFJLEJ().SetFloat("Please attach component to a Graphical UI component", PosX);
			PHGCJOPFDOG().SetFloat("[RanksSystem] Map hash: ", PosY);
			BFGNMFCNDBC().SetColor("_TimeX", color);
			EOCCJGIGEGJ().SetVector("Connection error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 285f, 346f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Screens");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void PBEPCAPAKLG()
	{
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1432f)
			{
				HBJJOCHGOPH = 1467f;
			}
			HHIAIGCAHDA().SetFloat("HandleEventLeave for player ID: ", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("PRESS A KEY", Tiles);
			MJJIEHANFJA().SetFloat("Send", Speed);
			FHFLKLMFHOI().SetFloat("Move environment object to the position", PosX);
			FHFLKLMFHOI().SetFloat("LevelProgressBar", PosY);
			PHGCJOPFDOG().SetColor("CameraFilterPack/Vision_Rainbow", color);
			CIAFLBFJLEJ().SetVector("true", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1105f, 1205f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}
}
