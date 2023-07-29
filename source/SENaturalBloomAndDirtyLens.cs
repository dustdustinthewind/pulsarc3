// SENaturalBloomAndDirtyLens
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Sonic Ether/SE Natural Bloom and Dirty Lens")]
public class SENaturalBloomAndDirtyLens : MonoBehaviour
{
	[Range(0f, 0.4f)]
	public float bloomIntensity = 0.05f;

	public Shader shader;

	private Material NBPKMLMCHFN;

	public Texture2D lensDirtTexture;

	[Range(0f, 0.95f)]
	public float lensDirtIntensity = 0.05f;

	private bool LMKGCBNNGLI;

	private float NCCDJFKEGLH = 4f;

	public bool inputIsHDR;

	private void HMPGIFBJFIK()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)98;
		NBPKMLMCHFN.SetFloat("_CenterX", Mathf.Exp(bloomIntensity) - 1438f);
		NBPKMLMCHFN.SetFloat("\\n", Mathf.Exp(lensDirtIntensity) - 1560f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 113f;
		int num4 = 5;
		for (int i = 1; i < 2; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1599f : 349f);
			if (i == 7)
			{
				num3 = 544f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_ScreenResolution", (NCCDJFKEGLH * 38f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("maps.", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_FarCamera", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Horizontal", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("st", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("new round", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)74;
		NBPKMLMCHFN.SetFloat("_Value", Mathf.Exp(bloomIntensity) - 317f);
		NBPKMLMCHFN.SetFloat("_Color", Mathf.Exp(lensDirtIntensity) - 1207f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 846f;
		int num4 = 3;
		for (int i = 1; i < 8; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 459f : 568f);
			if (i == 8)
			{
				num3 = 234f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("SAVE FILE", (NCCDJFKEGLH * 1548f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("GroupNameText", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture(" not exist", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("[PlayerBase] Loaded custom model: ", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(".", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 3;
		}
		NBPKMLMCHFN.SetTexture("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		NBPKMLMCHFN.SetFloat(".GoalProgress", Mathf.Exp(bloomIntensity) - 1156f);
		NBPKMLMCHFN.SetFloat("Traffic Stats", Mathf.Exp(lensDirtIntensity) - 103f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1875f;
		int num4 = 0;
		for (int i = 0; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 274f : 1434f);
			if (i == 0)
			{
				num3 = 816f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("HPToggle", (NCCDJFKEGLH * 1130f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Multiplayer", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Blue_B", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("#random #common #item", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_FgOverlap", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("finished", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("_Value", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void HHKBBEFJEBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		NBPKMLMCHFN.SetFloat("Gameplay/particles", Mathf.Exp(bloomIntensity) - 792f);
		NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_Myst", Mathf.Exp(lensDirtIntensity) - 1690f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 958f;
		int num4 = 8;
		for (int i = 0; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 724f : 523f);
			if (i == 7)
			{
				num3 = 1009f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_LinearLight", (NCCDJFKEGLH * 1378f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("{0}", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture(".wav", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("MouseY", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Bad parameters for getint! Use <key> <value>", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(" ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("_Value", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void ICILLMAKLMI()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void NBGIMIDICKE()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void FLKEJJEGCFA()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void KOJKBFDNGDK()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void ABIOAMNCEOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("HiddenToggle", Mathf.Exp(bloomIntensity) - 566f);
		NBPKMLMCHFN.SetFloat("color", Mathf.Exp(lensDirtIntensity) - 1720f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1057f;
		int num4 = 7;
		for (int i = 1; i < 8; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1699f : 1107f);
			if (i == 6)
			{
				num3 = 1532f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", (NCCDJFKEGLH * 1762f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_BlurDirectionPacked", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture(" from: ", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("#close", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value1", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Ascii", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Radius", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("_ScreenResolution", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void HGJJPACDBEP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)119;
		NBPKMLMCHFN.SetFloat(" Remote called.", Mathf.Exp(bloomIntensity) - 536f);
		NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(lensDirtIntensity) - 393f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1062f;
		int num4 = 6;
		for (int i = 0; i < 2; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1645f : 1937f);
			if (i == 4)
			{
				num3 = 1176f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat(" - ", (NCCDJFKEGLH * 1126f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("#tryagain", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Operation failed: ", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_CenterX", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("closed", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("z", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CCLNNLCOPBL()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void EDPDMBFLHLP()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void JABNHMIHBHC()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void BGMNONMHAJP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-117);
		NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(bloomIntensity) - 1166f);
		NBPKMLMCHFN.SetFloat("Reset All", Mathf.Exp(lensDirtIntensity) - 1760f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 253f;
		int num4 = 4;
		for (int i = 0; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 243f : 157f);
			if (i == 0)
			{
				num3 = 1296f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_Value", (NCCDJFKEGLH * 1490f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Item ", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("yyyy-MM-dd HH:mm:ss", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_ConsoleSettings", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("[EMPTY]", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Best region found in PlayerPrefs. Connecting to: ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("SendVacantViewIds()", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void GKNKIIEALCH()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		NBPKMLMCHFN.SetFloat("VIGNETTE_BLUR", Mathf.Exp(bloomIntensity) - 1759f);
		NBPKMLMCHFN.SetFloat("#ok", Mathf.Exp(lensDirtIntensity) - 1613f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 608f;
		int num4 = 6;
		for (int i = 1; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 879f : 1048f);
			if (i == 1)
			{
				num3 = 565f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_ScreenResolution", (NCCDJFKEGLH * 1607f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Set EnvSprite Image", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_CameraToWorldMatrix", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("restart", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("[Up-Right-Left]", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("Loss ", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void DHENLPJJOEN()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void BAEHKBADMAO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MEBPBNLBECA()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void FEHCNJLLJMP()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void KLDNGKBMDAN()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		NBPKMLMCHFN.SetFloat("MenuScene", Mathf.Exp(bloomIntensity) - 994f);
		NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_Chromatic_Aberration", Mathf.Exp(lensDirtIntensity) - 383f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 553f;
		int num4 = 0;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 990f : 386f);
			if (i == 2)
			{
				num3 = 1070f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_Amount", (NCCDJFKEGLH * 1117f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("<b>#", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_NoOuterClip", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("skin.", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("/", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Player Connected", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("Please wait..", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideAndDontSave;
		NBPKMLMCHFN.SetFloat("_BloomIntensity", Mathf.Exp(bloomIntensity) - 1f);
		NBPKMLMCHFN.SetFloat("_LensDirtIntensity", Mathf.Exp(lensDirtIntensity) - 1f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1f;
		int num4 = 2;
		for (int i = 0; i < 6; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 0.5f : 1f);
			if (i == 2)
			{
				num3 = 0.75f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_BlurSize", (NCCDJFKEGLH * 0.5f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Bloom0", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Bloom1", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Bloom2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Bloom3", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Bloom4", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Bloom5", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("_LensDirt", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CEDFFAOOPOG()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void MFBCLNAHEFO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void NFJFHPCMEGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		NBPKMLMCHFN.SetFloat("Result for ", Mathf.Exp(bloomIntensity) - 519f);
		NBPKMLMCHFN.SetFloat("OK", Mathf.Exp(lensDirtIntensity) - 1341f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 516f;
		int num4 = 6;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 668f : 672f);
			if (i == 6)
			{
				num3 = 1326f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat(".completedMaps", (NCCDJFKEGLH * 680f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("#startofflinemessage", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("[MenuScene] Error: ", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture(".", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("EventSystem", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture(" not exist", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void NEFHGMNAPEP()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void GNJDKAECPKA()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)96;
		NBPKMLMCHFN.SetFloat("mapselector.filter.rateduponly", Mathf.Exp(bloomIntensity) - 846f);
		NBPKMLMCHFN.SetFloat("InfoText", Mathf.Exp(lensDirtIntensity) - 1663f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1446f;
		int num4 = 4;
		for (int i = 1; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 222f : 1259f);
			if (i == 1)
			{
				num3 = 1107f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("maps.", (NCCDJFKEGLH * 970f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("The shader ", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_DistortionSize", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("yyyy-MM-dd HH:mm:ss", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("Joystick1Button10", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void CGDMLHLJIDK()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void AKHCOBHHGJP()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void OnDisable()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MKIMDFLBFOM()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void CCFEDENFNEF()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-126);
		NBPKMLMCHFN.SetFloat("PhotonView with ID ", Mathf.Exp(bloomIntensity) - 1721f);
		NBPKMLMCHFN.SetFloat("Vertical", Mathf.Exp(lensDirtIntensity) - 1273f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1879f;
		int num4 = 3;
		for (int i = 1; i < 5; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1620f : 1420f);
			if (i == 8)
			{
				num3 = 1271f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("workshop.", (NCCDJFKEGLH * 184f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Blue_C", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("player.orangelifering", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/TV_Videoflip", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture(".r", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("offsets", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Version 1.0", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("input", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void MGMAOBPPOBJ()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void JKMBDBCDJAL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)69;
		NBPKMLMCHFN.SetFloat("skin.", Mathf.Exp(bloomIntensity) - 1890f);
		NBPKMLMCHFN.SetFloat("menuthemes", Mathf.Exp(lensDirtIntensity) - 1758f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1225f;
		int num4 = 3;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 497f : 1762f);
			if (i == 5)
			{
				num3 = 821f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("#scoresubmitionfailed: ", (NCCDJFKEGLH * 1117f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("[LevelEditorScene] Error: You're not logged into Steam!", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("EndlessLoopsScoreText", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Colors_DarkColor", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("SetScale", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("LoadPlayerSkin", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("DPADVER", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void BMIOFJFMCBG()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void MODENHKMKOC()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void KDOCJGGAOII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)76;
		NBPKMLMCHFN.SetFloat("inventory.selected.", Mathf.Exp(bloomIntensity) - 626f);
		NBPKMLMCHFN.SetFloat("Missing shader in ", Mathf.Exp(lensDirtIntensity) - 1822f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1765f;
		int num4 = 7;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 115f : 717f);
			if (i == 8)
			{
				num3 = 491f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("LevelEditor/icons", (NCCDJFKEGLH * 1576f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("/icon", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("VisionBlur", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Keypad", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("InventoryButton", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("#FFFFFF", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void FHGKIOOMMOH()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void Start()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void PLEOOAJIMEE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~HideFlags.HideInInspector;
		NBPKMLMCHFN.SetFloat("_Value5", Mathf.Exp(bloomIntensity) - 1690f);
		NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper2", Mathf.Exp(lensDirtIntensity) - 952f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1895f;
		int num4 = 6;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 912f : 1857f);
			if (i == 7)
			{
				num3 = 1262f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_GreenAmplifier", (NCCDJFKEGLH * 1999f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Scenes List:", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("inventory.selected.", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("DPADHOR", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_SecondTex", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("[MenuScene] Error: ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("float,2", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void LINKAMEPKGM()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void BNLENEDAHHL()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IDJKNBDKHBD()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void NPLCENPNJBM()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void KMCPMOGKDEH()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		NBPKMLMCHFN.SetFloat("FToA", Mathf.Exp(bloomIntensity) - 1665f);
		NBPKMLMCHFN.SetFloat("mapselector.orderby", Mathf.Exp(lensDirtIntensity) - 489f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 165f;
		int num4 = 3;
		for (int i = 1; i < 6; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 106f : 292f);
			if (i == 5)
			{
				num3 = 828f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_Offsets", (NCCDJFKEGLH * 1205f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("element", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture(".jpg", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Day_", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_ReflectionTexture3", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("Done!", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CHOPDIGHJNH()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void ALNNIDLFILB()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void DAHFFNNIGML()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void HCDBNAKGDJC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", Mathf.Exp(bloomIntensity) - 797f);
		NBPKMLMCHFN.SetFloat("BadgeText", Mathf.Exp(lensDirtIntensity) - 839f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1542f;
		int num4 = 2;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1914f : 200f);
			if (i == 1)
			{
				num3 = 1317f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_Screen", (NCCDJFKEGLH * 592f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Near", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture(".lastCheckpoint.checkpointsUsed", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_FixDistance", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("[DiscordController] Sectate ({0})", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("ns", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("Failed to 'GetKeyCode' for key: ", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void IHAAHFFMJLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-112);
		NBPKMLMCHFN.SetFloat("quit", Mathf.Exp(bloomIntensity) - 465f);
		NBPKMLMCHFN.SetFloat("_Value2", Mathf.Exp(lensDirtIntensity) - 1627f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 844f;
		int num4 = 2;
		for (int i = 0; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1129f : 735f);
			if (i == 5)
			{
				num3 = 130f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("Fade", (NCCDJFKEGLH * 63f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_BorderSize", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_EmissionColor", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Items", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("arcs", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("/", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void NDBPCNICGLC()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void EGKNJMMAOAO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-107);
		NBPKMLMCHFN.SetFloat("EnableRankingToggle", Mathf.Exp(bloomIntensity) - 1344f);
		NBPKMLMCHFN.SetFloat("/Saved Games/", Mathf.Exp(lensDirtIntensity) - 577f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 951f;
		int num4 = 8;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1378f : 728f);
			if (i == 7)
			{
				num3 = 787f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", (NCCDJFKEGLH * 1258f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture(".highscore", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_LightIntensity", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("UseFinalGlassColor", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_SprTex", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Crosshair1", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_CameraWS", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("_Red_B", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void MMPHNFPPEHO()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void KHIGHFJKPFG()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void KPOCGNOKNOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-86);
		NBPKMLMCHFN.SetFloat("VisionBlur", Mathf.Exp(bloomIntensity) - 1007f);
		NBPKMLMCHFN.SetFloat("Left", Mathf.Exp(lensDirtIntensity) - 298f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1567f;
		int num4 = 0;
		for (int i = 0; i < 5; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 1821f : 1716f);
			if (i == 7)
			{
				num3 = 890f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("23x3", (NCCDJFKEGLH * 1146f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_HSV", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("GlassColor", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("ArcsDestroyDelaySlider", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Traffic Stats", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("mainmenu", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void GENCBNFIILN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		NBPKMLMCHFN.SetFloat("_Value3", Mathf.Exp(bloomIntensity) - 208f);
		NBPKMLMCHFN.SetFloat("ShowSprite", Mathf.Exp(lensDirtIntensity) - 1020f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1583f;
		int num4 = 8;
		for (int i = 1; i < 0; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 415f : 1201f);
			if (i == 2)
			{
				num3 = 1708f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_Color", (NCCDJFKEGLH * 1464f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("[NetworkManager] Connecting...", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_PosX", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Radius", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("[Up-Right-Down]", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("[ItemsHandler] Loading ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("SetSunDirectionVector", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture(".lastCheckpoint.bgcolor", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void ALJEJJCIMJN()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-107);
		NBPKMLMCHFN.SetFloat("finished", Mathf.Exp(bloomIntensity) - 1451f);
		NBPKMLMCHFN.SetFloat("Case-Sensitive", Mathf.Exp(lensDirtIntensity) - 762f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 395f;
		int num4 = 1;
		for (int i = 1; i < 1; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 593f : 1026f);
			if (i == 7)
			{
				num3 = 401f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("yes", (NCCDJFKEGLH * 112f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Year_", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("-1", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("bans.viewed.", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("To Log", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Glasses_On", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("_FarCamera", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)116;
		NBPKMLMCHFN.SetFloat("RoomDescriptionText", Mathf.Exp(bloomIntensity) - 905f);
		NBPKMLMCHFN.SetFloat("_Value5", Mathf.Exp(lensDirtIntensity) - 400f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1283f;
		int num4 = 7;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1653f : 38f);
			if (i == 8)
			{
				num3 = 1177f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", (NCCDJFKEGLH * 1545f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("PerfectHitsScoreText", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("ShadersToggle", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture(": ", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_OffsetScale", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("mapselector.filter.subscribedonly", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("_SweaterSize", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void LKBOEPPBLIF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)117;
		NBPKMLMCHFN.SetFloat("GameScene", Mathf.Exp(bloomIntensity) - 393f);
		NBPKMLMCHFN.SetFloat("_PosY", Mathf.Exp(lensDirtIntensity) - 1382f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 111f;
		int num4 = 0;
		for (int i = 1; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 798f : 1322f);
			if (i == 8)
			{
				num3 = 1079f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("Screen Space Reflections", (NCCDJFKEGLH * 1569f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("settings.volume.menu", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("UsernameText", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("GhostFade", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Inside cells:\n", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("maps.", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("settings.disablestoryboard", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void MNBPNHNAEBK()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void OPHBLNNGFKG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)96;
		NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(bloomIntensity) - 202f);
		NBPKMLMCHFN.SetFloat("BadgeText", Mathf.Exp(lensDirtIntensity) - 723f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1315f;
		int num4 = 1;
		for (int i = 1; i < 6; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 654f : 248f);
			if (i == 7)
			{
				num3 = 1064f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_Near", (NCCDJFKEGLH * 1234f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_PrevViewProj", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("UseScanLine", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("TotalHitsScoreText", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_BlurPass", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("setfloat", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Scene", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("_ColorBuffer", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JCCIHFMBFJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", Mathf.Exp(bloomIntensity) - 1082f);
		NBPKMLMCHFN.SetFloat("settings.shaders.bloomintencity", Mathf.Exp(lensDirtIntensity) - 917f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1818f;
		int num4 = 0;
		for (int i = 0; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 728f : 1611f);
			if (i == 3)
			{
				num3 = 1700f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", (NCCDJFKEGLH * 508f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Coroutine container not configured... did you forget to call Init?", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("[Left]", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("ticket.ticket1", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(" evLeave: ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("[SteamManager] Connection established, authorization", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		NBPKMLMCHFN.SetFloat("_LutTex", Mathf.Exp(bloomIntensity) - 9f);
		NBPKMLMCHFN.SetFloat("Set Crosshair Color", Mathf.Exp(lensDirtIntensity) - 1520f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 413f;
		int num4 = 6;
		for (int i = 1; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 979f : 487f);
			if (i == 0)
			{
				num3 = 1910f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("data", (NCCDJFKEGLH * 1583f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("SlidingArea", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("maps.", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("event", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Red_G", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("FileLabel", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void GAANDCGCBHF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		NBPKMLMCHFN.SetFloat("HandleEventLeave for player ID: ", Mathf.Exp(bloomIntensity) - 953f);
		NBPKMLMCHFN.SetFloat("ready", Mathf.Exp(lensDirtIntensity) - 1679f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 325f;
		int num4 = 5;
		for (int i = 0; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1350f : 279f);
			if (i == 6)
			{
				num3 = 1777f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_BlurRadius4", (NCCDJFKEGLH * 1360f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("HandsCountSlider", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("shader.frost", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Oct", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("\\\\", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("#newhighscore", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("Set sun beat detection sensitivity", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void ILCFPCIPENO()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void FIKFJDFELIP()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-67);
		NBPKMLMCHFN.SetFloat("/", Mathf.Exp(bloomIntensity) - 1242f);
		NBPKMLMCHFN.SetFloat("PunSupportLogger", Mathf.Exp(lensDirtIntensity) - 567f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1465f;
		int num4 = 4;
		for (int i = 1; i < 3; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 1804f : 1055f);
			if (i == 3)
			{
				num3 = 1407f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_Distance", (NCCDJFKEGLH * 889f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_DistortionLevel", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("blue", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_CutOff", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("GlassesColor", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Threshold", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("#mapnotloaded", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture(", data: ", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void HPFOFGJPNCI()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		NBPKMLMCHFN.SetFloat("UseScanLineSize", Mathf.Exp(bloomIntensity) - 547f);
		NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(lensDirtIntensity) - 1436f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1619f;
		int num4 = 4;
		for (int i = 0; i < 0; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1367f : 1622f);
			if (i == 6)
			{
				num3 = 1299f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("cipherText", (NCCDJFKEGLH * 837f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("z", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("GlassAberration", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_AdaptParams", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("MouseX", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_DiffuseColor", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_EmissionColor", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("ReconnectAndRejoin() disabled the offline mode. No longer offline.", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void AEMGPJDJGBJ()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IKDNLHLBHID()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void DPLLKHHLDBB()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IMCKJCHKMKB()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void JIHNFLGAMJE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		NBPKMLMCHFN.SetFloat("float,0", Mathf.Exp(bloomIntensity) - 796f);
		NBPKMLMCHFN.SetFloat("_Val2", Mathf.Exp(lensDirtIntensity) - 1405f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 132f;
		int num4 = 1;
		for (int i = 1; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 239f : 291f);
			if (i == 2)
			{
				num3 = 537f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Luminosity", (NCCDJFKEGLH * 1463f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_Overlay", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("settings.cameramovements", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("UpperMid", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture(",", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(") but there is no recycle bin setup for it", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("BackButton", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("1", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void LFAFJKJAEEL()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void JKBMKPDGCHG()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void KOIKNJLPOPA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-69);
		NBPKMLMCHFN.SetFloat("[NetworkManager] Join failed", Mathf.Exp(bloomIntensity) - 875f);
		NBPKMLMCHFN.SetFloat("_LensDirt", Mathf.Exp(lensDirtIntensity) - 302f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1882f;
		int num4 = 2;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1823f : 1371f);
			if (i == 0)
			{
				num3 = 1322f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("Set the end of the map. Use this if you want to cut the long music.", (NCCDJFKEGLH * 475f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_TapMedium", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_ColorDodge", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture(":</b> ", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("https://www.youtube.com/watch?v=cDVXukrKo74", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Blue_G", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("ICollection", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void PMPKMGKAAJH()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-68);
		NBPKMLMCHFN.SetFloat("settings.selectormapsperpage", Mathf.Exp(bloomIntensity) - 1061f);
		NBPKMLMCHFN.SetFloat(" (inactive)", Mathf.Exp(lensDirtIntensity) - 1872f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1839f;
		int num4 = 1;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 489f : 945f);
			if (i == 4)
			{
				num3 = 1926f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("SetSunLerpSpeed", (NCCDJFKEGLH * 920f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Lut_PlayWith", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("ResetSpeed", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("SetRotation", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("Ownership mode == fixed. Ignoring request.", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-127);
		NBPKMLMCHFN.SetFloat("#restart", Mathf.Exp(bloomIntensity) - 1280f);
		NBPKMLMCHFN.SetFloat("BadgeText", Mathf.Exp(lensDirtIntensity) - 946f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1798f;
		int num4 = 7;
		for (int i = 0; i < 5; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 371f : 885f);
			if (i == 2)
			{
				num3 = 1539f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat(".played", (NCCDJFKEGLH * 1511f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("mapselector.orderby", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("GameModeText", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Visualize", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("</color>", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("UseScanLine", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Set EnvSprite Color", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("_TimeX", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void NEIOOEKEOPC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-69);
		NBPKMLMCHFN.SetFloat("_Distance", Mathf.Exp(bloomIntensity) - 1223f);
		NBPKMLMCHFN.SetFloat(" isInactive: ", Mathf.Exp(lensDirtIntensity) - 1377f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 175f;
		int num4 = 5;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1963f : 1188f);
			if (i == 2)
			{
				num3 = 507f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", (NCCDJFKEGLH * 933f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Set Sun MaxSize", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("mapselector.filter.favoriteonly", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Vertical", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Tab2Content", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("0", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Color_BrightContrastSaturation", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("[LevelEditorScene] Print Audio Wave: Start", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void FNCDAPDOBBI()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void HIPEHGNBJMN()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void DOFDGBGEDFI()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)92;
		NBPKMLMCHFN.SetFloat("maps.", Mathf.Exp(bloomIntensity) - 769f);
		NBPKMLMCHFN.SetFloat("menu.tabid", Mathf.Exp(lensDirtIntensity) - 418f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1629f;
		int num4 = 8;
		for (int i = 1; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1010f : 375f);
			if (i == 8)
			{
				num3 = 1798f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_BlurPass", (NCCDJFKEGLH * 1281f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Tab2Content", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("View ({3}){0} on {1} {2}", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Vision_Hell_Blood", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("RoomPlayersCountText", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("y", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("BadgeText", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void BOPKKCAFODF()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void ANCKKLFPGDI()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy;
		NBPKMLMCHFN.SetFloat("settings.enableranking", Mathf.Exp(bloomIntensity) - 1834f);
		NBPKMLMCHFN.SetFloat("mapselector.filter.officialsortmode", Mathf.Exp(lensDirtIntensity) - 384f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1190f;
		int num4 = 8;
		for (int i = 0; i < 5; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1466f : 942f);
			if (i == 4)
			{
				num3 = 1204f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_TimeX", (NCCDJFKEGLH * 1965f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_LightIntensity", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("OK", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Hello World, is my item a clone? [", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("input", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Gain", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Glitch1", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-119);
		NBPKMLMCHFN.SetFloat("maps.", Mathf.Exp(bloomIntensity) - 1441f);
		NBPKMLMCHFN.SetFloat("_BlurVector", Mathf.Exp(lensDirtIntensity) - 1867f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1045f;
		int num4 = 6;
		for (int i = 1; i < 7; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1280f : 968f);
			if (i == 6)
			{
				num3 = 1254f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("QuickSave", (NCCDJFKEGLH * 472f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture(" method: ", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_FixDistance", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Distortion", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("HiddenToggle", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CNPINCHINJA()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void LGHCJCFHEMF()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)79;
		NBPKMLMCHFN.SetFloat("#", Mathf.Exp(bloomIntensity) - 288f);
		NBPKMLMCHFN.SetFloat("_Value", Mathf.Exp(lensDirtIntensity) - 1689f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 108f;
		int num4 = 1;
		for (int i = 0; i < 2; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 314f : 1526f);
			if (i == 8)
			{
				num3 = 1786f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("ItemNameText", (NCCDJFKEGLH * 1797f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Red_R", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("GraphicsQualitySlider", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Color_G", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("id", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("<b>(╯°□°）╯︵ ┻━┻</b>", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JOHOFNKJDEB()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void AIBNKIDADPI()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void IHLMNAGPKDA()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("_Value", Mathf.Exp(bloomIntensity) - 1631f);
		NBPKMLMCHFN.SetFloat(" ", Mathf.Exp(lensDirtIntensity) - 572f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 992f;
		int num4 = 7;
		for (int i = 1; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 413f : 1302f);
			if (i == 5)
			{
				num3 = 194f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("InfoCanvas", (NCCDJFKEGLH * 1169f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("mapselector.filter.favoriteonly", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Items/", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Case-Sensitive", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("[PlayerController] ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Up", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("Mouse1", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void JOPCCCCHNLI()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void DHLCNIINMDM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)76;
		NBPKMLMCHFN.SetFloat("[ItemsHandler] Item not found:", Mathf.Exp(bloomIntensity) - 148f);
		NBPKMLMCHFN.SetFloat("LB", Mathf.Exp(lensDirtIntensity) - 1400f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1456f;
		int num4 = 3;
		for (int i = 0; i < 2; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 678f : 537f);
			if (i == 8)
			{
				num3 = 788f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("Save the map before exiting?", (NCCDJFKEGLH * 1406f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture(" not exist", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("UseScanLineSize", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("bad", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("en", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("offsets", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}
}
