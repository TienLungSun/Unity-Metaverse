
        private void OnCollisionEnter(Collision col)
        {
            if (col.transform.CompareTag(tagToDetect))
            {
                //onCollisionEnterEvent.Invoke(col);
                //Debug.Log("Target hit by " + col.gameObject.name);

                //search for top parent which is the RagDoll
                GameObject walker = col.gameObject.transform.root.gameObject;
                // call the TouchedTarget function to add rewards
                walker.GetComponent<WalkerAgent>().TouchedTarget();

                if (respawnIfTouched)
                {
                    MoveTargetToRandomPosition();
                }
            }
        }
