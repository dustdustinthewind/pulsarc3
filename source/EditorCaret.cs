// EditorCaret
using UnityEngine;

public class EditorCaret : MonoBehaviour
{
	private MapEditor LBFPCCEFBBL;

	private Vector3 CPCNODILEAE;

	public float z;

	public float lerpSpeed = 5f;

	public int asourceid;

	public bool moveOnlyWhenPlaying;

	public bool forcePosition;

	public bool useScale = true;

	public float scaleSize = 1f;

	private float CGCGPJAEDII;

	private void HLDFOJMHKNL()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 977f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 379f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 38, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 73, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-119), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-63), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void JOACBIEHHCE()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1067f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1678f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-84), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 30, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 32, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-8), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void OMCLOFCJMPG()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1825f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 776f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-93), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 19, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-104) : 0, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-55), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void OEENOOGEEHD()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 790f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 853f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-45), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 105, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-25), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-91), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void Start()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void KIEJKBNBHMD()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 252f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 735f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 48, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 126, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-120), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-21), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void NNCCPEBIAKH()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void FOMNCPKKCFN()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 340f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1824f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 62, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-18), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-100), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 115, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void BGFJOEPFOPM()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 765f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 869f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 12, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 46 : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-75), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 115, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void KLILJHJNICK()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void AEEGKLABFLN()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1662f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1909f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-88), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 104, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-101) : 0, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : 51, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void PDHKMDBNGGN()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void FJNCHGLIEMA()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void LEAHIBJDMBI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1894f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 195f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-57), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-72) : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-41), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-59), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void MMOKKAPFGAK()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void EJFJENFKLND()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 307f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1081f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 77, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-79), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-124), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-29), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void JAAJECBCCFM()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 644f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 606f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 111, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-116) : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-97), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 60, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void JBCNIPJDPJB()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1792f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 121f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-98), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : 99, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 13, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-38), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void FLKEJJEGCFA()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void AEIJFLJEABG()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 699f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1470f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 40 : 0, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 117, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 89, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 81, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void IBHACCEEFFI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 793f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 648f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : 5, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-56) : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 2, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 89, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void EHCGBJDFMHG()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 803f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1552f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 30, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 80, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 90, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 4, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void HMNLHMLILKD()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 474f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1845f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 110, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-51) : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-44), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-28), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void JILOMOBDPIA()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void MMMDPANNAIO()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void EGEGNHLODAA()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1078f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 135f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 107, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-6), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : 87, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-125), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void BMOFEBKGLFI()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void BGDPIHMAACO()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void EGEPLFGKGLI()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void FBPHNEJBDJN()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void DPIPGGDNGHN()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 265f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 599f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-92), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-111), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 87, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 92, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void OBAEDJJDCPN()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1279f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 17f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-35), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-102), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-23), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 10, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void CCLNNLCOPBL()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void MFMIODIAKNI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1769f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1975f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 14, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 54, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 9, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-14), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void IHLMNAGPKDA()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void AAPKBNDHBLI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1536f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 429f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-78), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-93), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-8), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 4, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void HAIAHJPCPAG()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void PBEPCAPAKLG()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 467f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1504f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 80, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-63) : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-15) : 0, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 74, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void HLIAEEMGBHN()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void EPEGAEGDJAM()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void DNENFLNCIJP()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1369f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 152f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 125, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 64 : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 47, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-32), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void ICILLMAKLMI()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void DLBODOFAJGM()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void KNBJBNDGCIJ()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void MJNPIDGNJMK()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 86f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1080f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-64), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : 105, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 100, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 101 : 0, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void JKFDDNMPOJH()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void FABMDEHEDNO()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1930f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1885f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : 32, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 71, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-79), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : 57, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void LJIHHJOAJCN()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1714f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 833f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-25), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 9, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-15) : 0, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 17 : 0, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void MAOCOEGAFND()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1158f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1255f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 32, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-2), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-33) : 0, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 79 : 0, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void PAKPHKPDKGE()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void GHILDCBCDJI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1104f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1205f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 70 : 0, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-81), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : 23, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-6), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void KDMANOEMOCA()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void ILCFPCIPENO()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void DAHFFNNIGML()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void MECJHOJPODB()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 799f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 737f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-26), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-9), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : 71, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-28), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void FBMDHDBELEK()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1724f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 989f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-19), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-124), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 3, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-115), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void OHFOLGANOLC()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void JHPOIOELNCG()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1705f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 281f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : 123, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-61), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-31), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-122), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void Update()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 30f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 0f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void KMCPMOGKDEH()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void NEKCPLGFOFD()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 610f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 49f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 45, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-118), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : 35, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-62), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void AGMJDGHLBMN()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 947f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1311f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 82, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 68, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 114, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 112, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void ANCKKLFPGDI()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void HDDECCMEJKA()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1626f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1703f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : 115, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-47), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-67), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 43, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void MNBPNHNAEBK()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void KFACDBHDAOD()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 841f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1792f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 82, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 23, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-127), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 45, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void HMPGIFBJFIK()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void LPMINJJPDCH()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 236f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1654f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 75, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 98, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 122 : 0, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 50, z), Time.deltaTime * lerpSpeed);
		}
	}
}
