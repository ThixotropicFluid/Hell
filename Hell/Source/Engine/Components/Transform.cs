using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Unity.Mathematics.math;
using Unity.Mathematics;


namespace Hell.Source.Engine.Components
{
    internal class Transform : Component
    {
        public gameObject _object; // the object which this component is attached to


        public Transform(gameObject @object) { 
            _object = @object;
            parent = null;
            children = new List<Transform>();
            hasChanged = false;
        }
        public Transform(gameObject @object, float3 _localPostition, float3 _localScale, quaternion _localRotation)
        {
            _object = @object;
            parent = null;
            children = new List<Transform>();
            hasChanged = false;

            localPosition = _localPostition;
            localScale = _localScale;
            localRotation = _localRotation;

        }

        public Transform parent = null; // transform of perent
        public List<Transform> children = new List<Transform>();

        private float3 LocalPosition;
        private float3 LocalScale;
        private quaternion LocalRotation; // externally writable

        public float3 position { get; private set; }
        public float3 scale { get; private set; }
        public quaternion rotation { get; private set; }

        public float3 localPosition { get { return LocalPosition; } set { LocalPosition = value; this.hasChanged = true; } }
        public float3 localScale { get { return LocalScale; } set { LocalScale = value; this.hasChanged = true; } }
        public quaternion localRotation { get { return LocalRotation; } set { LocalRotation = value; this.hasChanged = true; } }

        private bool hasChanged;
        public bool HasChanged { get { return hasChanged; } }



        public override ReturnStates Update()
        {
            if (hasChanged)
            {
                ResolveTransform(); // for when code executues, physics dealt with seperately
                if (children.Count > 0)
                    ResolveChildrenTransform();
            }

            return ReturnStates.Succeed;
        }
        public void SetParent(Transform tr) { 
            parent = tr;
            tr.children.Add(this);
        }
        public void ResolveTransform() {

            // resolve absolute trasform given change in local
            if (parent != null)
            {
                position = parent.position + localPosition;
            }
            else {
                position = localPosition;
            }




            hasChanged = false;
        }
        public void Move() { 
        
        } // moves transform with collsions
        private void BackPropogate()
        {
            throw new NotImplementedException();
        } // back propogate forces to prevent intercection

        public void ResolveChildrenTransform()
        {
            foreach (Transform trans in children)
            {
                if (trans == null)
                {
                    Debug.Logger.LogWarning("Attempted to accsess null transform");
                }
                trans.ResolveTransform();
            }
        }
    }
}
