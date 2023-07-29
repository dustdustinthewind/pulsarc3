// CameraFilterPack_FX_Screens
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Screens")]
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
			BFGNMFCNDBC().SetFloat("_Value5", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("{0}", Tiles);
			PHGCJOPFDOG().SetFloat("GlassesColor2", Speed);
			DEFBJOCJJKF().SetFloat("Case-Sensitive", PosX);
			NBPKMLMCHFN.SetFloat("speed", PosY);
			BFGNMFCNDBC().SetColor("Tab2Content", color);
			BFGNMFCNDBC().SetVector("_RedAmplifier", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1637f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		SCShader = Shader.Find("_Sat");
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
		SCShader = Shader.Find("PunPickupSimple");
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
			PDEAHJPOMEF().SetFloat("_TimeX", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("maps.", Tiles);
			FHFLKLMFHOI().SetFloat("Save", Speed);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", PosX);
			DKKBFFHBHJE().SetFloat("materialsitemid[", PosY);
			NJDIODJNGGA().SetColor(" Owner called.", color);
			NJDIODJNGGA().SetVector("DPADHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1068f, 1629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		SCShader = Shader.Find("_OcclusionBlurTexture");
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
		SCShader = Shader.Find("y");
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
			HKHBBBFLGJH().SetFloat("_Value3", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("\"", Tiles);
			NJDIODJNGGA().SetFloat(": ", Speed);
			PHGCJOPFDOG().SetFloat("Mouse Y", PosX);
			HKHBBBFLGJH().SetFloat("CompletedLevel", PosY);
			PDEAHJPOMEF().SetColor("HPToggle", color);
			DKNJGHFLAIF().SetVector("\r", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			HKGAONMOBMH().SetFloat("SetPlayerDistance", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_RampTex", Tiles);
			BKKJJJGADLM().SetFloat("_Value4", Speed);
			NBPKMLMCHFN.SetFloat("SupportLogger OnJoinedLobby(", PosX);
			HEINDEMCGIK().SetFloat("Obtain promo Item", PosY);
			ABHDNGIHBKE().SetColor("_CenterY", color);
			DKNJGHFLAIF().SetVector("AvatarImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1979f, 555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			MJJIEHANFJA().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_Value7", Tiles);
			HHIAIGCAHDA().SetFloat("_Value", Speed);
			HKHBBBFLGJH().SetFloat("_SmoothEnd", PosX);
			PDEAHJPOMEF().SetFloat("RarityImage", PosY);
			FHFLKLMFHOI().SetColor("<b>", color);
			BKKJJJGADLM().SetVector("cmd.exe", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 578f, 390f));
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
		SCShader = Shader.Find("[PlayerController] ");
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
			KAFBNOBOIAJ().SetFloat("settings.volume.game", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Freq: ", Tiles);
			FHFLKLMFHOI().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", Speed);
			PHGCJOPFDOG().SetFloat(".icon", PosX);
			HKGAONMOBMH().SetFloat("Metal", PosY);
			ABHDNGIHBKE().SetColor("x", color);
			BFGNMFCNDBC().SetVector("_CenterX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1782f, 1700f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
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
			ABHDNGIHBKE().SetFloat("22x3", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("SUBMIT '{0}' FILES", Tiles);
			HHIAIGCAHDA().SetFloat("Texture2", Speed);
			PHGCJOPFDOG().SetFloat("_Value3", PosX);
			OLHDPICFBOF().SetFloat("SetSpeed", PosY);
			NJDIODJNGGA().SetColor("1", color);
			DEFBJOCJJKF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1686f, 470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			BKKJJJGADLM().SetFloat("[NetworkScene] Exited", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_ScreenResolution", Tiles);
			BKKJJJGADLM().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", Speed);
			DKNJGHFLAIF().SetFloat("OnEvent: {0}", PosX);
			HKHBBBFLGJH().SetFloat("_TimeX", PosY);
			KEMAALEODNH().SetColor("[MapEditor] Updating map assets", color);
			CIAFLBFJLEJ().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1574f, 1800f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
		SCShader = Shader.Find(".workshop.json");
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
			HKGAONMOBMH().SetFloat("Joystick1Button4", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("ShadersToggle", Tiles);
			HHIAIGCAHDA().SetFloat("Lag ", Speed);
			LPMLLJKMAMP().SetFloat("_Parasite", PosX);
			ABHDNGIHBKE().SetFloat("Keeping GameObject in the scene: ", PosY);
			LPMLLJKMAMP().SetColor("D-Pad Down", color);
			EOCCJGIGEGJ().SetVector(" timeUntilRespawnBasedOnTimeBase:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1556f, 1787f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
		SCShader = Shader.Find(".completedMaps");
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
			EOCCJGIGEGJ().SetFloat("_Value7", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Map id for", Tiles);
			EOCCJGIGEGJ().SetFloat("Overlay", Speed);
			NJDIODJNGGA().SetFloat("CameraFilterPack/FX_Hypno", PosX);
			NBPKMLMCHFN.SetFloat("/", PosY);
			HKHBBBFLGJH().SetColor("tolobby", color);
			FAIFBBGFAIB().SetVector("CameraFilterPack/Glow_Glow", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1727f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
		SCShader = Shader.Find("Run a command for the Localization Servise");
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
			CIAFLBFJLEJ().SetFloat("Indie", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat(" to: ", Tiles);
			DNLMFEGJJDD().SetFloat("offsets", Speed);
			ABHDNGIHBKE().SetFloat("id", PosX);
			PDEAHJPOMEF().SetFloat("Switch environment sprite image", PosY);
			PDEAHJPOMEF().SetColor("settings.crosshairopacity", color);
			EPCGJFCCAFH().SetVector("GroupNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 437f, 469f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			CIAFLBFJLEJ().SetFloat("_FadeFX", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("null", Tiles);
			EPCGJFCCAFH().SetFloat("_Value2", Speed);
			DEFBJOCJJKF().SetFloat("Set particless emission (glow)", PosX);
			PHGCJOPFDOG().SetFloat("0 - default, 1 - left, 2 - right", PosY);
			KAFBNOBOIAJ().SetColor("Connection error: ", color);
			HEINDEMCGIK().SetVector("skin.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 281f, 825f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			HKHBBBFLGJH().SetFloat(".played", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_TexelOffsetScale", Tiles);
			FHFLKLMFHOI().SetFloat("menu.playedsolo", Speed);
			HKGAONMOBMH().SetFloat("Start index must in an integer.", PosX);
			FHFLKLMFHOI().SetFloat("speed", PosY);
			MJJIEHANFJA().SetColor("SpawnObj", color);
			HKGAONMOBMH().SetVector("0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1307f, 1688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("Attempting to remove texture that was not allocated: {0}");
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
			ABHDNGIHBKE().SetFloat("cipherText", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_AlphaHexa", Tiles);
			HKGAONMOBMH().SetFloat("_TimeX", Speed);
			FAIFBBGFAIB().SetFloat("_SceneFogMode", PosX);
			BKKJJJGADLM().SetFloat("ticket", PosY);
			OLHDPICFBOF().SetColor(" : ", color);
			PHGCJOPFDOG().SetVector("Editor/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 589f, 586f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find(" takes from: ");
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
			HHIAIGCAHDA().SetFloat("[MapEditor] Loaded music file: ", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("_TapLowForeground", Tiles);
			BKKJJJGADLM().SetFloat("_Offsets", Speed);
			KAFBNOBOIAJ().SetFloat("float,1.5", PosX);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/Glasses_OnX", PosY);
			PDEAHJPOMEF().SetColor("Keypad", color);
			MJJIEHANFJA().SetVector("EventData0DropDownList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1427f, 1337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			DEFBJOCJJKF().SetFloat("ok", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_EmissionColor", Tiles);
			HKHBBBFLGJH().SetFloat("VIGNETTE_DESAT", Speed);
			FAIFBBGFAIB().SetFloat(" not exist", PosX);
			KAFBNOBOIAJ().SetFloat("_Intensity", PosY);
			MJJIEHANFJA().SetColor("_ScreenResolution", color);
			DNLMFEGJJDD().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1073f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("g");
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
			OLHDPICFBOF().SetFloat("_History1LumaTex", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Distortion_Aspiration", Tiles);
			PDEAHJPOMEF().SetFloat("settings.shaders", Speed);
			OIIDAKBILMI().SetFloat("MapConfig", PosX);
			BKKJJJGADLM().SetFloat("In Map Editor", PosY);
			PDEAHJPOMEF().SetColor("SetSatelliteColor", color);
			EPCGJFCCAFH().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 477f, 603f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
			MJJIEHANFJA().SetFloat("float,1", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat(".lastCheckpoint.powerupsScore", Tiles);
			OLHDPICFBOF().SetFloat("[Right]", Speed);
			LPMLLJKMAMP().SetFloat("/", PosX);
			DEFBJOCJJKF().SetFloat("skin.", PosY);
			HKHBBBFLGJH().SetColor("_ScreenResolution", color);
			FHFLKLMFHOI().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1351f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			PDEAHJPOMEF().SetFloat("_Val", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_TimeX", Tiles);
			HEINDEMCGIK().SetFloat("settings.volume.game", Speed);
			KAFBNOBOIAJ().SetFloat("LevelNameInputField", PosX);
			HKGAONMOBMH().SetFloat("Skipping EstablishEncryption. Protocol is secure.", PosY);
			MJJIEHANFJA().SetColor("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", color);
			NBPKMLMCHFN.SetVector("PLEASE WAIT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1845f, 362f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			KAFBNOBOIAJ().SetFloat("[MapsData] Found ", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("(?<=#)\\w+", Tiles);
			CIAFLBFJLEJ().SetFloat("_TimeX", Speed);
			HKGAONMOBMH().SetFloat("_Value3", PosX);
			OIIDAKBILMI().SetFloat("Joystick1Button4", PosY);
			DKNJGHFLAIF().SetColor("float,0", color);
			EOCCJGIGEGJ().SetVector("_SpawnHeuristic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 58f, 1209f));
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
			ABHDNGIHBKE().SetFloat("_DepthLevel", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_ReflectionTexture3", Tiles);
			HKGAONMOBMH().SetFloat("00", Speed);
			EPCGJFCCAFH().SetFloat("violet", PosX);
			ABHDNGIHBKE().SetFloat("MapCreationCanvas", PosY);
			BFGNMFCNDBC().SetColor(" ; ", color);
			DKNJGHFLAIF().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 750f, 383f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
			DKNJGHFLAIF().SetFloat("_TimeX", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat(" but this PhotonView does not exist! Was remote PV.", Tiles);
			HKHBBBFLGJH().SetFloat("_MainTex2", Speed);
			EPCGJFCCAFH().SetFloat("UI Extensions/UIMultiply", PosX);
			LPMLLJKMAMP().SetFloat("[MapsStats] Length: ", PosY);
			DEFBJOCJJKF().SetColor("_Distortion", color);
			DKNJGHFLAIF().SetVector("[RanksSystem] Ranks updated. Next update: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 285f, 346f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			BKKJJJGADLM().SetFloat("HandleEventLeave for player ID: ", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("DPADVER", Tiles);
			CIAFLBFJLEJ().SetFloat("player ", Speed);
			OIIDAKBILMI().SetFloat("Move environment object to the position", PosX);
			HNFFHCLNBDN().SetFloat("Fill Area", PosY);
			OLHDPICFBOF().SetColor("_Value", color);
			ABHDNGIHBKE().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1105f, 1205f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
