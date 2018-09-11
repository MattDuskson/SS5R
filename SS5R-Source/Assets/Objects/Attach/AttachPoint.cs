﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPoint : Interactable {
    public GameObject targetPrefab;

    Attacher attached;

    public override bool GetInteractable(Interactor interactor) {
        return base.GetInteractable(interactor) && attached == null;
    }

    public override void InteractWith(Interactor interactor) {
        Attacher attacher = interactor.GetComponent<Attacher>();
        attached = attacher;
        interactor.GetComponent<Attacher>().SetAttached(this);
    }
}
