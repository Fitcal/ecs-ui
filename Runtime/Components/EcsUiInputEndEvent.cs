// ----------------------------------------------------------------------------
// The MIT License
// Ui extension https://github.com/Leopotam/ecs-ui
// for ECS framework https://github.com/Leopotam/ecs
// Copyright (c) 2017-2019 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine.UI;

namespace Leopotam.Ecs.Ui.Components {
    [EcsOneFrame]
    public sealed class EcsUiInputEndEvent : IEcsAutoResetComponent {
        public string WidgetName;
        public InputField Sender;
        public string Value;

        void IEcsAutoResetComponent.Reset () {
            Sender = null;
        }
    }
}