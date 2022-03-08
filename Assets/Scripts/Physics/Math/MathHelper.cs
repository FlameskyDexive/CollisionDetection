using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
// using UnityEngine;


public static class MathHelper
{

    public static float AbsDot3(Vector3 v1, Vector3 v2)
    {
        return (Math.Abs((v1).X * (v2).X) + Math.Abs((v1).Y * (v2).Y) + Math.Abs((v1).Z * (v2).Z));
    }

    public static Vector3 Abs(Vector3 v3)
    {
        return new Vector3(Math.Abs(v3.X), Math.Abs(v3.Y), Math.Abs(v3.Z));
    }

    public static float DistanceSq(Vector3 a, Vector3 rhs)
    {
        float dx = a.X - rhs.X;
        float dy = a.Y - rhs.Y;
        float dz = a.Z - rhs.Z;
        return dx * dx + dy * dy + dz * dz;
    }


    public static Vector3 ConvertVector3(UnityEngine.Vector3 v3)
    {
        return new Vector3(v3.x, v3.y, v3.z);
    }
    public static Quaternion ConvertQuaternion(UnityEngine.Quaternion qua)
    {
        return new Quaternion(qua.x, qua.y, qua.z, qua.w);
    }
    public static Vector3 TransformWithoutOverlap(Quaternion rotation, Vector3 point)
    {
        float num1 = rotation.X * 2f;
        float num2 = rotation.Y * 2f;
        float num3 = rotation.Z * 2f;
        float num4 = rotation.X * num1;
        float num5 = rotation.Y * num2;
        float num6 = rotation.Z * num3;
        float num7 = rotation.X * num2;
        float num8 = rotation.X * num3;
        float num9 = rotation.Y * num3;
        float num10 = rotation.W * num1;
        float num11 = rotation.W * num2;
        float num12 = rotation.W * num3;
        Vector3 vector3;
        vector3.X = (float)((1.0 - ((double)num5 + (double)num6)) * (double)point.X + ((double)num7 - (double)num12) * (double)point.Y + ((double)num8 + (double)num11) * (double)point.Z);
        vector3.Y = (float)(((double)num7 + (double)num12) * (double)point.X + (1.0 - ((double)num4 + (double)num6)) * (double)point.Y + ((double)num9 - (double)num10) * (double)point.Z);
        vector3.Z = (float)(((double)num8 - (double)num11) * (double)point.X + ((double)num9 + (double)num10) * (double)point.Y + (1.0 - ((double)num4 + (double)num5)) * (double)point.Z);
        return vector3;
    }


    public static float Sqrt(float f) => (float)Math.Sqrt((double)f);

    public static float[] v3Array(Vector3 vec3)
    {
        float[] array = new float[3];
        array[0] = vec3.X;  
        array[1] = vec3.Y;
        array[2] = vec3.Z;
        return array;
    }


    /*public static Vector3 Normalize(Vector3 v3)
    {
        float num = Magnitude(v3);
        if ((double)num > 9.99999974737875E-06)
            v3 = v3 / num;
        else
            v3 = Vector3.Zero;
        return v3;
    }*/

    public static float Clamp(float value, float min, float max)
    {
        if ((double)value < (double)min)
            value = min;
        else if ((double)value > (double)max)
            value = max;
        return value;
    }


    public static Vector3 Normalize(this Vector3 v3)
    {
        float num = Magnitude(v3);
        if ((double)num > 9.99999974737875E-06)
            v3 = v3 / num;
        else
            v3 = Vector3.Zero;
        return v3;
    }

    public static float Magnitude(Vector3 vector) => (float)Math.Sqrt((double)vector.X * (double)vector.X + (double)vector.Y * (double)vector.Y + (double)vector.Z * (double)vector.Z);
}