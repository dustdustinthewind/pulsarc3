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

	public float MIMAJIICPPI()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void DGNDMEFFIHJ(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	public void SetAnimationProperties(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	private void LBFLFFGLMDB()
	{
		AnimationParts.IFMFPKCCPDI(AFEPHFKDPLJ);
	}

	public bool HEHPNAJNACK()
	{
		return currentAnimationGoing.IsObjectOpened();
	}

	private void Update()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	public bool JEEOPHJBDNO()
	{
		return currentAnimationGoing.IsObjectOpened();
	}

	public void JNFEGDMEPBM(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void SetFade(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	public float LBALNPDHDOA()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void ODJBGKGFCOE()
	{
		rectTransform.gameObject.SetActive(true);
		HKEEFJNMELI();
	}

	public void OpenCloseObjectAnimation()
	{
		rectTransform.gameObject.SetActive(true);
		PKEGMGDIOFC();
	}

	public bool BBHGMKJBJDD()
	{
		return currentAnimationGoing.IsObjectOpened();
	}

	public void PNNINMIAIMC(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	public void BFMMOCAEPBO(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void MFGACFMPBLK(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(true);
			return;
		}
		if ((bool)base.gameObject && !rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	public void SetAnimationRotation(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void AJPCCBJIBAG()
	{
		rectTransform.gameObject.SetActive(false);
		currentAnimationGoing.PlayOpenAnimations();
	}

	private void ALHIAPNCNJO(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(true);
			return;
		}
		if ((bool)base.gameObject && !rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	private void AKHCOBHHGJP()
	{
		AnimationParts.OFKCCGIBMBL(ALHIAPNCNJO);
	}

	public void CCDJIFDHEHC(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	private void AFEPHFKDPLJ(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
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

	private void DIAGGJLLHNM()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	public void CloseObjectAnimation()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayCloseAnimations();
	}

	public void EGKLOOOAABN(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void PJJFOMGJFEF(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void EBBFHFNMPGN()
	{
		rectTransform.gameObject.SetActive(false);
		currentAnimationGoing.PlayOpenAnimations();
	}

	public void HEGLICFNJCM(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.IPAHMDHMJJA(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, rectTransform);
	}

	private void DEPPMIPBPAL()
	{
		AnimationParts.IFMFPKCCPDI(GKAMHPGDDDJ);
	}

	public void CDDCKIGAIPJ(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.BHBNCDBPJGC(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void SetUnscaledTimeAnimation(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void BAGJNDODMCP()
	{
		rectTransform.gameObject.SetActive(true);
		AKJIJDFJIKB();
	}

	public void GIAJEMNMCDA()
	{
		rectTransform.gameObject.SetActive(false);
		PFAGIGECCPI();
	}

	public void NIFKHIHNCLF(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void DJLKKODJHNP()
	{
		rectTransform.gameObject.SetActive(false);
		AKJIJDFJIKB();
	}

	public void HLNJDJINAEB(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.BHBNCDBPJGC(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void GCDLIKEDMCF()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	public EasyTween()
	{
		IFAFAMAHOFL();
	}

	public void FGGLNMNKLDA(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		currentAnimationGoing.DHLIPMHGCPE(NGHFGPKHIPP, HHABIDFFNCK);
	}

	public float FHHJEHCKHLK()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	private void GHFAPNJOIFG()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	public void MJMFGEKNBMO()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.OANPGIEACCJ();
	}

	public void NFEKKNPOGJL(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void LDCNNJIDDCO()
	{
		if (!currentAnimationGoing.IsObjectOpened())
		{
			currentAnimationGoing.OANPGIEACCJ();
		}
		else
		{
			currentAnimationGoing.PlayCloseAnimations();
		}
	}

	public void KDHFIKLGIKB(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 256f)
		{
			currentAnimationGoing.HAPEMNJGBDM(HNIFGMOMJMA);
		}
		else
		{
			currentAnimationGoing.NIEPJFJALLE(846f);
		}
	}

	public bool IsObjectOpened()
	{
		return currentAnimationGoing.IsObjectOpened();
	}

	public bool KMCEIMLEPHI()
	{
		return currentAnimationGoing.IsObjectOpened();
	}

	private void CCDAMMPPNBE()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	public void ABIPHKLOLPK(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationPos(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, rectTransform);
	}

	private void CCLNNLCOPBL()
	{
		AnimationParts.OFKCCGIBMBL(JKHKAJGEGPA);
	}

	public void JOABFAPOOEN(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void OHDOCLGPIOE(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationPos(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, rectTransform);
	}

	public float HINPIKCEJBO()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void SetAnimationScale(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void MFCHIHFBPJM()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	public void ADDJMLHCDLP(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	public void HEJIOJFNELP()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.OANPGIEACCJ();
	}

	private void BGDPIHMAACO()
	{
		AnimationParts.OFKCCGIBMBL(NPAPLLCBKBB);
	}

	private void HKEEFJNMELI()
	{
		if (!currentAnimationGoing.IsObjectOpened())
		{
			currentAnimationGoing.OANPGIEACCJ();
		}
		else
		{
			currentAnimationGoing.PlayCloseAnimations();
		}
	}

	private void NPAPLLCBKBB(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(true);
			return;
		}
		if ((bool)base.gameObject && (bool)rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	private void BMODOIJGIOO()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	private void BBFPEIOPDBE()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	public float EPDECNEHFKJ()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	private void HCIPECAOGIA()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	private void EOIFKKMNKDF(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
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

	private void KHBLMEGPPLJ()
	{
		AnimationParts.OnDisableOrDestroy -= ALHIAPNCNJO;
	}

	private void HILFFNEFMDH()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	public void LFAOKGDLHOL(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	public void AIJLDMCAFFK(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 439f)
		{
			currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			currentAnimationGoing.NIEPJFJALLE(365f);
		}
	}

	public void BHKGDGPOHJB(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	private void EPEGAEGDJAM()
	{
		AnimationParts.OFKCCGIBMBL(AJOEMNCKMKM);
	}

	public void AEGDJMJMDLI()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayOpenAnimations();
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

	public void AMGBJCBJFAO(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public float IJEBHBDHGBP()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void HPCFHELOPIF(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		currentAnimationGoing.DHLIPMHGCPE(NGHFGPKHIPP, HHABIDFFNCK);
	}

	public void KMDNJBKLGJE(bool CIOKILFKPHF)
	{
		currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	public void OPDGGPAMDKP(bool CIOKILFKPHF)
	{
		currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	private void EGEGNHLODAA()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	private void Start()
	{
		AnimationParts.OnDisableOrDestroy += AJOEMNCKMKM;
	}

	private void LateUpdate()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	public void DBNBGCEDMOP(bool CIOKILFKPHF)
	{
		currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	public void LDPPOOHLHCF()
	{
		rectTransform.gameObject.SetActive(false);
		currentAnimationGoing.PlayCloseAnimations();
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

	private void ELENIBFBCIH()
	{
		if (!currentAnimationGoing.IsObjectOpened())
		{
			currentAnimationGoing.OANPGIEACCJ();
		}
		else
		{
			currentAnimationGoing.PlayCloseAnimations();
		}
	}

	public void HMCGOFELEDH(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void BBINADBINLO(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationPos(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, rectTransform);
	}

	public void KGBPGOALNEN(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void GNOICDLLBJI(bool CIOKILFKPHF)
	{
		currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	public void SetAnimationPosition(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationPos(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, rectTransform);
	}

	public float GetAnimationDuration()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public float FPJLKOKKALO()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void SetFadeStartEndValues(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		currentAnimationGoing.SetFadeValuesStartEnd(NGHFGPKHIPP, HHABIDFFNCK);
	}

	private void PEJANHIKFAE()
	{
		AnimationParts.IFMFPKCCPDI(NPAPLLCBKBB);
	}

	public void FEECHDIIKIB(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void OFDDJDDCKIJ(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	public void IEJEOOEPMAC(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	private void OnDestroy()
	{
		AnimationParts.OnDisableOrDestroy -= AJOEMNCKMKM;
	}

	public void JBEADLHMKMA()
	{
		currentAnimationGoing.SetFade(true);
	}

	public void PFIDMLHIKMF(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 1286f)
		{
			currentAnimationGoing.HAPEMNJGBDM(HNIFGMOMJMA);
		}
		else
		{
			currentAnimationGoing.NIEPJFJALLE(123f);
		}
	}

	public void PKICDNINIGD()
	{
		currentAnimationGoing.SetFade(false);
	}

	public void JFOLLDDMOMK(bool CIOKILFKPHF)
	{
		currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	private void PINCEMDKGEO(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(true);
			return;
		}
		if ((bool)base.gameObject && !rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	private void JDKHBGDEONK()
	{
		AnimationParts.OFKCCGIBMBL(JKHKAJGEGPA);
	}

	private void AKJIJDFJIKB()
	{
		if (!currentAnimationGoing.IsObjectOpened())
		{
			currentAnimationGoing.PlayOpenAnimations();
		}
		else
		{
			currentAnimationGoing.LEKPODLMAPB();
		}
	}

	public bool FDPFHFMNBEA()
	{
		return currentAnimationGoing.IsObjectOpened();
	}

	public void EOHJLPNDLMJ(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		currentAnimationGoing.DHLIPMHGCPE(NGHFGPKHIPP, HHABIDFFNCK);
	}

	public void GHJAOJFBALP(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void CGCBCNLIING(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void OpenObjectAnimation()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayOpenAnimations();
	}

	public float ICMIAICHKNE()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void PCGHIEANBMH()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.OANPGIEACCJ();
	}

	public void PONIOLPJPFI(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	public void PGOIEGKLAKO(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.IPAHMDHMJJA(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, rectTransform);
	}

	private void GNBHNEIHANF()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
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

	public void MDKPMHHLKIE()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.LEKPODLMAPB();
	}

	public float PDOLGNFAIGJ()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public float EHNKEKJEJMJ()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}

	public void AILAMHCFDOB()
	{
		rectTransform.gameObject.SetActive(true);
		AKJIJDFJIKB();
	}

	public void BPGIHPKCMNF(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 1077f)
		{
			currentAnimationGoing.FPEACNPHNKD(HNIFGMOMJMA);
		}
		else
		{
			currentAnimationGoing.HAPEMNJGBDM(1903f);
		}
	}

	public void IPAJDFPKHPD(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.BHBNCDBPJGC(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	private void PFAGIGECCPI()
	{
		if (!currentAnimationGoing.IsObjectOpened())
		{
			currentAnimationGoing.OANPGIEACCJ();
		}
		else
		{
			currentAnimationGoing.PlayCloseAnimations();
		}
	}

	public void ENLKJIDCJDN()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayCloseAnimations();
	}

	public void PHJPDEPMLEF()
	{
		rectTransform.gameObject.SetActive(false);
		currentAnimationGoing.LEKPODLMAPB();
	}

	public void DOCILNBKKAA(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	public void DMMEHNCIKDG()
	{
		rectTransform.gameObject.SetActive(false);
		AKJIJDFJIKB();
	}

	public void HMAPIGMDKPA(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	public void HJEJDEPEDGD(bool HCAIOLGHFNN)
	{
		animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	public void AIOOFAMNMOJ(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	private void FNENCNMBNGC()
	{
		AnimationParts.IFMFPKCCPDI(NPAPLLCBKBB);
	}

	private void POIMNOBDBBN()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	private void KHIGHFJKPFG()
	{
		AnimationParts.OnDisableOrDestroy += MFGACFMPBLK;
	}

	public void EGDLPMFNPPC(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		currentAnimationGoing.DHLIPMHGCPE(NGHFGPKHIPP, HHABIDFFNCK);
	}

	private void IFAFAMAHOFL()
	{
		if (currentAnimationGoing == null)
		{
			SetAnimationProperties(animationParts);
		}
	}

	public void BIIIKDKNLHH()
	{
		currentAnimationGoing.SetFade(false);
	}

	private void JKHKAJGEGPA(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
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

	public void SetFade()
	{
		currentAnimationGoing.SetFade(false);
	}

	public void EDDEOMIDBOL(AnimationParts KEMAFNIOEFC)
	{
		animationParts = KEMAFNIOEFC;
		currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	public void LMHFGDCFHOD()
	{
		rectTransform.gameObject.SetActive(false);
		LDCNNJIDDCO();
	}

	private void NFKJGOPAGPJ()
	{
		currentAnimationGoing.LateAnimationFrame(rectTransform);
	}

	private void IGOJCALJJFM()
	{
		AnimationParts.IFMFPKCCPDI(NPAPLLCBKBB);
	}

	public void ChangeSetState(bool CIOKILFKPHF)
	{
		currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	private void JCGMGLMADEN()
	{
		currentAnimationGoing.AnimationFrame(rectTransform);
	}

	private void GKAMHPGDDDJ(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			rectTransform.gameObject.SetActive(true);
			return;
		}
		if ((bool)base.gameObject && (bool)rectTransform.gameObject == (bool)base.gameObject)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.DestroyImmediate(rectTransform.gameObject);
	}

	public void BINMMEGPPOL(bool FOJONHLNAOM)
	{
		currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	public void LKOKMJPCDJO()
	{
		rectTransform.gameObject.SetActive(true);
		currentAnimationGoing.PlayCloseAnimations();
	}

	private void GFBCLCDEFKF()
	{
		if (currentAnimationGoing == null)
		{
			PONIOLPJPFI(animationParts);
		}
	}

	public float EBJLFLOGFBP()
	{
		return currentAnimationGoing.GetAnimationDuration();
	}
}
