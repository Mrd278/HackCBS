using UnityEngine;
using Vuforia;

public class ImageTargetPlayAudio : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public GameObject Quad;
    private Animator anim;
    //private MovieTexture movie;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        anim = Quad.GetComponent<Animator>();
        //movie = Quad.GetComponent<MovieTexture>();
        //movie.Pause();
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            anim.Play("Book");
            //movie.Play();
        }
        else
        {
            //movie.Pause();
            return;
        }
    }
}
