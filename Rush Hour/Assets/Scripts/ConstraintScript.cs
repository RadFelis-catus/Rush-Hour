using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConstraintScript
{
    public static bool HasConstraint(this RigidbodyConstraints2D thisConstraint, RigidbodyConstraints2D constraint) {
    	return (thisConstraint & constraint) != RigidbodyConstraints2D.None;
    }
}
