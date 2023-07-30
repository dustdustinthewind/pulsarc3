// CameraFilterPack_Gradients_ElectricGradient
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Gradients/Electric")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_ElectricGradient : MonoBehaviour
{
	public Shader SCShader;

	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_ElectricGradient";

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Switch = 1f;

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

	private void BGDONBMDPGM()
	{
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void FABKIGNFECE()
	{
	}

	private void Update()
	{
	}

	private void OCMKCBBCEFG()
	{
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void LMADKINICIN()
	{
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1114f)
			{
				HBJJOCHGOPH = 941f;
			}
			NBPKMLMCHFN.SetFloat("_Value", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_NoisePerChannel", Switch);
			FEAEGGCNIAA().SetFloat("SetParticlesParticleSpeed", Fade);
			NBPKMLMCHFN.SetVector("/icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 470f, 975f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 758f)
			{
				HBJJOCHGOPH = 1219f;
			}
			HHIAIGCAHDA().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat(") then the masterserver requests a disconnect!", Switch);
			FHFLKLMFHOI().SetFloat("GlassesColor2", Fade);
			FHFLKLMFHOI().SetVector("?page=addtip", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1056f, 187f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 549f)
			{
				HBJJOCHGOPH = 1090f;
			}
			HCGJCMDJPGD().SetFloat(" ", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("curScn", Switch);
			ABHDNGIHBKE().SetFloat("_ScreenResolution", Fade);
			DBOLLHHMKKN().SetVector("_FilteredReflections", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1670f, 1851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 336f)
			{
				HBJJOCHGOPH = 947f;
			}
			MCDGIILBNIF().SetFloat("_Value2", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Value4", Switch);
			LDNADDJMIPK().SetFloat("_Visualize", Fade);
			LDNADDJMIPK().SetVector("LostLive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1264f, 1591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 770f)
			{
				HBJJOCHGOPH = 685f;
			}
			LDNADDJMIPK().SetFloat("[MapsEditor] Creating new item...", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("LetterSpacing: Missing Text component", Switch);
			ABHDNGIHBKE().SetFloat("_Value2", Fade);
			FEAEGGCNIAA().SetVector("public", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1707f, 1604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void MFMIODIAKNI()
	{
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 124f)
			{
				HBJJOCHGOPH = 77f;
			}
			NBPKMLMCHFN.SetFloat("y", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Switch);
			NBPKMLMCHFN.SetFloat("+", Fade);
			HHIAIGCAHDA().SetVector("Call ConnectToNameServer to ping available regions.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 67f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1563f)
			{
				HBJJOCHGOPH = 1669f;
			}
			HHIAIGCAHDA().SetFloat("0 - default, 1 - left, 2 - right", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("BloodAlternative2", Switch);
			HHIAIGCAHDA().SetFloat("BadgeImage", Fade);
			LDNADDJMIPK().SetVector("_AlphaMask", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 520f, 681f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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

	private void MDCFIHDPLIG()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1561f)
			{
				HBJJOCHGOPH = 1492f;
			}
			FEAEGGCNIAA().SetFloat("_EdgeWeight", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", Switch);
			ABHDNGIHBKE().SetFloat("GroupNameText", Fade);
			DBOLLHHMKKN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1775f, 1129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1076f)
			{
				HBJJOCHGOPH = 106f;
			}
			FEAEGGCNIAA().SetFloat("\nCreated by Oxy949", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ToneCurve", Switch);
			NBPKMLMCHFN.SetFloat("NO", Fade);
			DBOLLHHMKKN().SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1521f, 1951f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1230f)
			{
				HBJJOCHGOPH = 1985f;
			}
			MCDGIILBNIF().SetFloat("[LocalizationService] Error: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("#FFFFFFFF", Switch);
			ABHDNGIHBKE().SetFloat("_Distortion", Fade);
			HHIAIGCAHDA().SetVector("_VelTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1068f, 1082f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void IFJDKDFLGBG()
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1494f)
			{
				HBJJOCHGOPH = 1090f;
			}
			MCDGIILBNIF().SetFloat(" argument(s): ", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("RarityImage", Switch);
			HHIAIGCAHDA().SetFloat("menu.selectedplaymode", Fade);
			HCGJCMDJPGD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1698f, 1656f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			NBPKMLMCHFN.SetFloat("_Value", Switch);
			NBPKMLMCHFN.SetFloat("_Value2", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 445f)
			{
				HBJJOCHGOPH = 1408f;
			}
			FHFLKLMFHOI().SetFloat("LevelConfigButton", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_ScreenResolution", Switch);
			HHIAIGCAHDA().SetFloat("Joystick1Button3", Fade);
			HCGJCMDJPGD().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1266f, 457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 873f)
			{
				HBJJOCHGOPH = 766f;
			}
			DBOLLHHMKKN().SetFloat("EventMenu", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("Anomaly_With_Obj", Switch);
			MCDGIILBNIF().SetFloat(". Client is not the MasterClient in this room.", Fade);
			HHIAIGCAHDA().SetVector("Down", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 621f, 1777f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1920f)
			{
				HBJJOCHGOPH = 1991f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Glasses_On", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", Switch);
			FEAEGGCNIAA().SetFloat("Joystick1Button6", Fade);
			LDNADDJMIPK().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1860f, 1171f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 611f)
			{
				HBJJOCHGOPH = 641f;
			}
			FHFLKLMFHOI().SetFloat("action", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("SUCCESS! Item submitted! :D :D :D", Switch);
			FHFLKLMFHOI().SetFloat("CameraFilterPack_Broken_Screen1", Fade);
			FHFLKLMFHOI().SetVector("float,1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1992f, 1043f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1902f)
			{
				HBJJOCHGOPH = 690f;
			}
			ABHDNGIHBKE().SetFloat("/icon", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("custom", Switch);
			NBPKMLMCHFN.SetFloat("buttons", Fade);
			NBPKMLMCHFN.SetVector(".completedMaps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 959f, 1351f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 206f)
			{
				HBJJOCHGOPH = 241f;
			}
			FEAEGGCNIAA().SetFloat("LivesSlider", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_TimeX", Switch);
			FEAEGGCNIAA().SetFloat("_Value", Fade);
			LDNADDJMIPK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1554f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			if (HBJJOCHGOPH > 736f)
			{
				HBJJOCHGOPH = 1023f;
			}
			FEAEGGCNIAA().SetFloat(",", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Value2", Switch);
			NBPKMLMCHFN.SetFloat("Bad parameters for setbool! Use <key> <value>", Fade);
			FEAEGGCNIAA().SetVector("EndlessLoopsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 357f, 1542f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}
}
