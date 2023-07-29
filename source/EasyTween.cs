// EasyTween
using System;
using UITween;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class EasyTween : MonoBehaviour
{
	public RectTransform rectTransform;

	public AnimationParts animationParts = new AnimationParts(AnimationParts.State.CLOSE, false, false, false, AnimationParts.EndTweenClose.DEACTIVATE, AnimationParts.CallbackCall.NOTHING, new UnityEvent(), new UnityEvent());

	private CurrentAnimation currentAnimationGoing;

	public void GIMKLENAIIO(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.MFKLABJCGMG(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void SetFadeStartEndValues(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		currentAnimationGoing.SetFadeValuesStartEnd(NGHFGPKHIPP, HHABIDFFNCK);
	}

	public void SetAnimatioDuration(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 0f)
		{
			currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			currentAnimationGoing.SetAniamtioDuration(0.01f);
		}
	}

	public void MHDEFCKEGEO()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayCloseAnimations();
	}

	private void IJHDFCAIPOP()
	{
		currentAnimationGoing.ECMBKPFMPEG(rectTransform);
	}

	public void PMGDBILDKGK(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 459f)
		{
			currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			currentAnimationGoing.SetAniamtioDuration(1364f);
		}
	}

	private void AEIJFLJEABG()
	{
		currentAnimationGoing.BFKJPGNMEJM(rectTransform);
	}

	public void ADJMKGJKIHC(bool CIOKILFKPHF)
	{
		currentAnimationGoing.IEPOJAMAJAK(CIOKILFKPHF);
	}

	public void SetAnimationProperties(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	public void ChangeSetState(bool CIOKILFKPHF)
	{
		currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	public void CHOODMAKIKD()
	{
		rectTransform.gameObject.SetActive(false);
		currentAnimationGoing.PlayOpenAnimations();
	}

	public void SetAnimationScale(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void OnDestroy()
	{
		AnimationParts.OnDisableOrDestroy -= AJOEMNCKMKM;
	}

	private void AKJIJDFJIKB()
	{
		if (!currentAnimationGoing.FPOJNHMKIDD())
		{
			currentAnimationGoing.BPIMHILGOMG();
		}
		else
		{
			currentAnimationGoing.PlayCloseAnimations();
		}
	}

	private void Update()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	public void MCLALIEOOLI(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 940f)
		{
			currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			currentAnimationGoing.SetAniamtioDuration(1621f);
		}
	}

	public void NCDHCJBEBNA(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void GPKPMAGKGFA(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(false);
			return;
		}
		if ((bool)base.gameObject && !rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	public void SetUnscaledTimeAnimation(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	private void PKEGMGDIOFC()
	{
		if (!currentAnimationGoing.IsObjectOpened())
		{
			currentAnimationGoing.PlayOpenAnimations();
		}
		else
		{
			currentAnimationGoing.PlayCloseAnimations();
		}
	}

	private void FABKIGNFECE()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	public void SetFade()
	{
		currentAnimationGoing.SetFade(false);
	}

	public void SetFade(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	private void IFAFAMAHOFL()
	{
		if (currentAnimationGoing == null)
		{
			SetAnimationProperties(animationParts);
		}
	}

	public void CloseObjectAnimation()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayCloseAnimations();
	}

	public void CNDMEAFLOAF(bool CIOKILFKPHF)
	{
		currentAnimationGoing.KLMNEMDBOOI(CIOKILFKPHF);
	}

	public void ADFHHDAGGLD()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayOpenAnimations();
	}

	public void OpenObjectAnimation()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayOpenAnimations();
	}

	public void ACHFFKPPJCN(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.CPPPMFEHBHD(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void JLBGEMKBIDO()
	{
		if (currentAnimationGoing == null)
		{
			LPAMCEDNAGB(animationParts);
		}
	}

	public float PDOLGNFAIGJ()
	{
		return currentAnimationGoing.EPDECNEHFKJ();
	}

	public void HAKBOKCEJON(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void IGPONOLDFMK(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		currentAnimationGoing.OKHHGLDKFMI(NGHFGPKHIPP, HHABIDFFNCK);
	}

	private void MKIMDFLBFOM()
	{
		AnimationParts.JAECJHCOHNH(LDKBFMGDMIP);
	}

	private void LDKBFMGDMIP(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(false);
			return;
		}
		if ((bool)base.gameObject && (bool)rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	private void AJOEMNCKMKM(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(false);
			return;
		}
		if ((bool)base.gameObject && !rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	private void LHLDDCILFAC()
	{
		if (currentAnimationGoing == null)
		{
			SetAnimationProperties(animationParts);
		}
	}

	public void NGAPEECMEJH(bool CIOKILFKPHF)
	{
		currentAnimationGoing.EMHCAMAACII(CIOKILFKPHF);
	}

	public void FKAEJEPJIEP()
	{
		rectTransform.gameObject.SetActive(false);
		currentAnimationGoing.PlayOpenAnimations();
	}

	public void OpenCloseObjectAnimation()
	{
		rectTransform.gameObject.SetActive(true);
		PKEGMGDIOFC();
	}

	public float GetAnimationDuration()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void SetAnimationRotation(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void SetAnimationPosition(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationPos(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, rectTransform);
	}

	private void FKBPBJBNFPA(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(false);
			return;
		}
		if ((bool)base.gameObject && (bool)rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	private void JNANCJOCAPA()
	{
		if (currentAnimationGoing == null)
		{
			SetAnimationProperties(animationParts);
		}
	}

	private void Start()
	{
		AnimationParts.OnDisableOrDestroy += AJOEMNCKMKM;
	}

	public void HOPJFMGADFG(bool CIOKILFKPHF)
	{
		currentAnimationGoing.AACJABEIENG(CIOKILFKPHF);
	}

	public void GEOJCPFLDFA()
	{
		rectTransform.gameObject.SetActive(false);
		currentAnimationGoing.BPIMHILGOMG();
	}

	public void PFBOGOCEFBA(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void LPAMCEDNAGB(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	public EasyTween()
	{
		IFAFAMAHOFL();
	}

	public void NIOMFNEEMDF()
	{
		rectTransform.gameObject.SetActive(false);
		PKEGMGDIOFC();
	}

	private void AGEJKLMJGDO()
	{
		AnimationParts.GNAHAFGFEIE(LDKBFMGDMIP);
	}

	public void KGHKFJMDLOL(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.MFKLABJCGMG(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public bool IsObjectOpened()
	{
		return currentAnimationGoing.IsObjectOpened();
	}

	private void KMKLDAJLCNM()
	{
		currentAnimationGoing.BFKJPGNMEJM(rectTransform);
	}

	public void HAKGPLODMJL(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void APAHOINHLAJ()
	{
		currentAnimationGoing.LGBCEGGCJMK(rectTransform);
	}

	public bool FJFANHLGGHL()
	{
		return currentAnimationGoing.JFOHIAKFPIO();
	}

	public void LEFOMFFHJCA(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	public void NOKKKPAJFFC(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.MFKLABJCGMG(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void NGJMAODBHMC(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	private void LateUpdate()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}
}
