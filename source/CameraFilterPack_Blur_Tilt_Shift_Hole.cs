// CameraFilterPack_Blur_Tilt_Shift_Hole
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Tilt_Shift_Hole")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Tilt_Shift_Hole : MonoBehaviour
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
	public float Size = 0.2f;

	[Range(-1f, 1f)]
	public float PositionX = 0.5f;

	[Range(-1f, 1f)]
	public float PositionY = 0.5f;

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

	private void KCDOMIJBFLL()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return BJFKDHHMLJH;
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 624f)
			{
				HBJJOCHGOPH = 1342f;
			}
			FEAEGGCNIAA().SetFloat("Set particles audio input", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("MissesText", Amount);
			GCDFNHMJMIP().SetFloat("_TimeX", Smooth);
			NLFJGMBCICG().SetFloat("\n\n• ", Size);
			BKKJJJGADLM().SetFloat("UI Extensions/UIAdditive", PositionX);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 1);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				ABHDNGIHBKE().SetFloat("_ScreenResolution", Amount * 1326f);
				Graphics.Blit(temporary2, temporary, BKKJJJGADLM(), 0);
				Graphics.Blit(temporary, temporary2, DBOLLHHMKKN(), 1);
				GCDFNHMJMIP().SetTexture("There is already a virtual button named ", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 842f)
			{
				HBJJOCHGOPH = 227f;
			}
			ACHNOHCLGOO().SetFloat("_Value2", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("AudioSampler", Amount);
			ABHDNGIHBKE().SetFloat("Menu", Smooth);
			GHHPOGODBHB().SetFloat("maps.", Size);
			GHHPOGODBHB().SetFloat("#mapby", PositionX);
			GHHPOGODBHB().SetFloat("PossibleMapPointsText", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, HCGJCMDJPGD(), 7);
				Graphics.Blit(temporary, temporary2, GHHPOGODBHB(), 0);
				LONNIJMNKFB().SetFloat("[MapEditor] Updating map assets", Amount * 1310f);
				Graphics.Blit(temporary2, temporary, PDEAHJPOMEF(), 6);
				Graphics.Blit(temporary, temporary2, HCGJCMDJPGD(), 1);
				IONHGBPGCHK().SetTexture("Reset 21 achievement progress", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ(), 0);
			}
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("position");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OFIMMFHFHDD()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ");
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1109f)
			{
				HBJJOCHGOPH = 890f;
			}
			NLFJGMBCICG().SetFloat("Committing changes...", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("Multiplayer", Amount);
			PDEAHJPOMEF().SetFloat("x", Smooth);
			FEAEGGCNIAA().SetFloat(" to ", Size);
			JIBOKBCPDLC().SetFloat("Can't do manual instantiation without PhotonView component.", PositionX);
			ACHNOHCLGOO().SetFloat("_TimeX", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, BKKJJJGADLM(), 0);
				Graphics.Blit(temporary, temporary2, EFDEIFCDAFG(), 1);
				BKKJJJGADLM().SetFloat("_FixDistance", Amount * 606f);
				Graphics.Blit(temporary2, temporary, FEAEGGCNIAA(), 8);
				Graphics.Blit(temporary, temporary2, IONHGBPGCHK(), 1);
				GCDFNHMJMIP().SetTexture("z", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1253f)
			{
				HBJJOCHGOPH = 970f;
			}
			FAIFBBGFAIB().SetFloat("_MainTex2", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat(" not found", Amount);
			GHHPOGODBHB().SetFloat("SetLives", Smooth);
			IIJMIPBMMBF().SetFloat("maps.", Size);
			NBPKMLMCHFN.SetFloat("SpawnObj", PositionX);
			FHFLKLMFHOI().SetFloat("_SizeX", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, BKKJJJGADLM(), 3);
				Graphics.Blit(temporary, temporary2, JIBOKBCPDLC(), 1);
				IONHGBPGCHK().SetFloat("Dec", Amount * 1621f);
				Graphics.Blit(temporary2, temporary, JIBOKBCPDLC(), 2);
				Graphics.Blit(temporary, temporary2, HCGJCMDJPGD(), 1);
				EFDEIFCDAFG().SetTexture("ticket", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD(), 1);
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

	private void HLDFOJMHKNL()
	{
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("Down");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void OEENOOGEEHD()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void DNENFLNCIJP()
	{
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1111f)
			{
				HBJJOCHGOPH = 36f;
			}
			EFDEIFCDAFG().SetFloat("SaveMapButton", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Jun", Amount);
			GHHPOGODBHB().SetFloat("Received event Leave for unknown player ID: {0}", Smooth);
			NLFJGMBCICG().SetFloat("maps.", Size);
			PDEAHJPOMEF().SetFloat("OpChangeGroups()", PositionX);
			LONNIJMNKFB().SetFloat("_Value", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NLFJGMBCICG(), 6);
				Graphics.Blit(temporary, temporary2, ABHDNGIHBKE(), 0);
				FAIFBBGFAIB().SetFloat("CameraFilterPack/Color_BrightContrastSaturation", Amount * 1654f);
				Graphics.Blit(temporary2, temporary, HCGJCMDJPGD(), 4);
				Graphics.Blit(temporary, temporary2, BKKJJJGADLM(), 0);
				IIJMIPBMMBF().SetTexture("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("Source directory does not exist or could not be found: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 700f)
			{
				HBJJOCHGOPH = 944f;
			}
			NLFJGMBCICG().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("Use ticket: ", Amount);
			PDEAHJPOMEF().SetFloat("RecieveChatActionMessage", Smooth);
			HCGJCMDJPGD().SetFloat("skin.", Size);
			FAIFBBGFAIB().SetFloat("Object ID. Case-Sensitive", PositionX);
			NBPKMLMCHFN.SetFloat("downloading", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, NDMPCDHADMJ(), 2);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 0);
				NFMGLIKNOOC().SetFloat("Fake", Amount * 390f);
				Graphics.Blit(temporary2, temporary, ABHDNGIHBKE(), 0);
				Graphics.Blit(temporary, temporary2, ABHDNGIHBKE(), 0);
				GHHPOGODBHB().SetTexture("ConfigVersionSlider", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD(), 0);
			}
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
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1604f)
			{
				HBJJOCHGOPH = 393f;
			}
			EFDEIFCDAFG().SetFloat("X", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("CameraFilterPack_Glasses_On6", Amount);
			NFMGLIKNOOC().SetFloat("&", Smooth);
			IIJMIPBMMBF().SetFloat("The other scroll rect doesnt support scrolling vertically", Size);
			NFMGLIKNOOC().SetFloat("_Value4", PositionX);
			FHFLKLMFHOI().SetFloat("[ResourcesManager] Load image error: ", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, NDMPCDHADMJ(), 7);
				Graphics.Blit(temporary, temporary2, JIBOKBCPDLC(), 0);
				ACHNOHCLGOO().SetFloat("?", Amount * 97f);
				Graphics.Blit(temporary2, temporary, GHHPOGODBHB(), 6);
				Graphics.Blit(temporary, temporary2, HCGJCMDJPGD(), 0);
				EFDEIFCDAFG().SetTexture("Joystick1Button7", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 287f)
			{
				HBJJOCHGOPH = 765f;
			}
			NDMPCDHADMJ().SetFloat("Set Trail Zoom Speed", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("(\\[ *i *\\])", Amount);
			NFMGLIKNOOC().SetFloat("MusicFileSelector", Smooth);
			LONNIJMNKFB().SetFloat("CameraFilterPack/FX_Scan", Size);
			GCDFNHMJMIP().SetFloat("_Value10", PositionX);
			LONNIJMNKFB().SetFloat("_TimeX", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, BKKJJJGADLM(), 4);
				Graphics.Blit(temporary, temporary2, EFDEIFCDAFG(), 0);
				FAIFBBGFAIB().SetFloat("time", Amount * 1743f);
				Graphics.Blit(temporary2, temporary, IONHGBPGCHK(), 8);
				Graphics.Blit(temporary, temporary2, BKKJJJGADLM(), 0);
				IONHGBPGCHK().SetTexture("itemdefid[0]", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("Working.\nPlease wait..");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("_Axis");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_BlurredColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 330f)
			{
				HBJJOCHGOPH = 358f;
			}
			EFDEIFCDAFG().SetFloat("[EditorEvent] Exception: ", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("CameraFilterPack_Glasses_On5", Amount);
			FAIFBBGFAIB().SetFloat("[Right]", Smooth);
			IONHGBPGCHK().SetFloat("Vertical", Size);
			FAIFBBGFAIB().SetFloat("_Offsets", PositionX);
			LONNIJMNKFB().SetFloat("resource", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, FHFLKLMFHOI(), 8);
				Graphics.Blit(temporary, temporary2, NLFJGMBCICG(), 0);
				FEAEGGCNIAA().SetFloat("settings.volume.editor", Amount * 109f);
				Graphics.Blit(temporary2, temporary, DBOLLHHMKKN(), 0);
				Graphics.Blit(temporary, temporary2, GCDFNHMJMIP(), 1);
				PDEAHJPOMEF().SetTexture("SetSunLerpSpeed", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/BlurTiltShift_Hole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1185f)
			{
				HBJJOCHGOPH = 875f;
			}
			NFMGLIKNOOC().SetFloat("[Left]", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat(".", Amount);
			FHFLKLMFHOI().SetFloat("CameraFilterPack/Retro_Loading", Smooth);
			GCDFNHMJMIP().SetFloat("SetTrailZoomSpeed", Size);
			FEAEGGCNIAA().SetFloat("nd", PositionX);
			DBOLLHHMKKN().SetFloat("_TimeX", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 7);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				ABHDNGIHBKE().SetFloat("Image", Amount * 1356f);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 5);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 0);
				IIJMIPBMMBF().SetTexture("_ScreenResolution", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_Value3", PositionX);
			NBPKMLMCHFN.SetFloat("_Value4", PositionY);
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

	private void PLIKADJCEPO()
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
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1042f)
			{
				HBJJOCHGOPH = 1076f;
			}
			ABHDNGIHBKE().SetFloat("DPADVER", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("menu.tabid", Amount);
			BKKJJJGADLM().SetFloat("settings.volume.sfx", Smooth);
			IIJMIPBMMBF().SetFloat("local CheckCondition = function()", Size);
			HCGJCMDJPGD().SetFloat(" Kb", PositionX);
			GCDFNHMJMIP().SetFloat("LevelFolderInputField", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO(), 0);
				Graphics.Blit(temporary, temporary2, NLFJGMBCICG(), 0);
				FEAEGGCNIAA().SetFloat("y", Amount * 1156f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				Graphics.Blit(temporary, temporary2, PDEAHJPOMEF(), 0);
				FAIFBBGFAIB().SetTexture("settings.arcsnohitsoundtimedelay", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE(), 1);
			}
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HNDNDPECBPL()
	{
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 838f)
			{
				HBJJOCHGOPH = 1027f;
			}
			FEAEGGCNIAA().SetFloat("Back", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("offsets", Amount);
			NBPKMLMCHFN.SetFloat("_Value3", Smooth);
			BKKJJJGADLM().SetFloat("_ReflectionBlur", Size);
			IIJMIPBMMBF().SetFloat("event", PositionX);
			IONHGBPGCHK().SetFloat(". Not connectedAndReady.", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 3);
				Graphics.Blit(temporary, temporary2, NLFJGMBCICG(), 1);
				PDEAHJPOMEF().SetFloat("speed", Amount * 215f);
				Graphics.Blit(temporary2, temporary, ACHNOHCLGOO(), 4);
				Graphics.Blit(temporary, temporary2, HCGJCMDJPGD(), 1);
				JIBOKBCPDLC().SetTexture("sprite", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1413f)
			{
				HBJJOCHGOPH = 1751f;
			}
			FAIFBBGFAIB().SetFloat("Player", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("No Name", Amount);
			NBPKMLMCHFN.SetFloat("ViewMenu", Smooth);
			IIJMIPBMMBF().SetFloat("value", Size);
			IONHGBPGCHK().SetFloat("Connection error: ", PositionX);
			FEAEGGCNIAA().SetFloat("request", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, NLFJGMBCICG(), 3);
				Graphics.Blit(temporary, temporary2, FEAEGGCNIAA(), 1);
				LONNIJMNKFB().SetFloat("/", Amount * 1023f);
				Graphics.Blit(temporary2, temporary, JIBOKBCPDLC(), 2);
				Graphics.Blit(temporary, temporary2, PDEAHJPOMEF(), 1);
				ACHNOHCLGOO().SetTexture("achievements.id", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN(), 1);
			}
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

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find(">");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find(".icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
