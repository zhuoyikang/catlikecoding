using UnityEngine;

public class BezierCurve : MonoBehaviour
{
    public Vector3[] _points;

    public void Reset()
    {
        _points = new []
        {
            new Vector3(1f, 0f, 0f),
            new Vector3(2f, 0f, 0f),
            new Vector3(3f, 0f, 0f),
        };
    }


    public Vector3 GetPoint(float t)
    {
        return transform.TransformPoint(Bezier.GetPoint(_points[0], _points[1], _points[2], t));
    }

	public Vector3 GetVelocity(float t)
	{
		return transform.TransformPoint(Bezier.GetFirstDerivative(_points[0], _points[1], _points[2], t)) -
			transform.position;
	}

	public Vector3 GetDirection(float t)
	{
		return GetVelocity(t).normalized;
	}

}
