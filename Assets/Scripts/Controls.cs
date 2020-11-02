// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""840a5aeb-9d7b-4955-880c-308069f28f9f"",
            ""actions"": [
                {
                    ""name"": ""Player 1 Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3dc6e962-c3fd-4bec-a015-2ad3e3d89847"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player 1 Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""16fbd47e-2a44-432d-9e96-f59581e1542b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player 1 Fire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b627abb3-96df-4ef5-b6c7-7af31949ffb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player 2 Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a50761e5-8f53-4249-8cd4-c5714c410b98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player 2 Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cfbd614c-2ac5-41b4-8721-803c0b3a6317"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player 2 Fire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""76a98d31-fb66-46ea-849e-3880ece5f268"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2692aa5b-16a4-48fd-b1ea-c850a5bcd1bd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 1 Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aebd981-c083-4b18-bbfc-19a9d7cbde21"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 2 Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""48c6abeb-69c2-43b7-90f1-02c47cd87191"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 1 Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6c7a7aef-729b-433f-8c5e-b7b6a02e8b38"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 1 Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""id"": ""393e8193-fc49-41a2-b8e7-9d293d627161"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 1 Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d6817948-929c-4b3b-b89f-fb6231164d88"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 1 Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""357e1641-8d11-4b75-96fe-682557642d06"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 2 Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""88988cb6-be63-42ab-8485-83067bb282aa"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 2 Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""id"": ""a939949c-ed2a-4428-b94e-f143b8e3389a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 2 Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""806c1f8c-45a5-4ffa-8a35-280160c80cfb"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player 2 Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Player1Move = m_Player.FindAction("Player 1 Move", throwIfNotFound: true);
        m_Player_Player1Rotate = m_Player.FindAction("Player 1 Rotate", throwIfNotFound: true);
        m_Player_Player1Fire = m_Player.FindAction("Player 1 Fire", throwIfNotFound: true);
        m_Player_Player2Move = m_Player.FindAction("Player 2 Move", throwIfNotFound: true);
        m_Player_Player2Rotate = m_Player.FindAction("Player 2 Rotate", throwIfNotFound: true);
        m_Player_Player2Fire = m_Player.FindAction("Player 2 Fire", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Player1Move;
    private readonly InputAction m_Player_Player1Rotate;
    private readonly InputAction m_Player_Player1Fire;
    private readonly InputAction m_Player_Player2Move;
    private readonly InputAction m_Player_Player2Rotate;
    private readonly InputAction m_Player_Player2Fire;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1Move => m_Wrapper.m_Player_Player1Move;
        public InputAction @Player1Rotate => m_Wrapper.m_Player_Player1Rotate;
        public InputAction @Player1Fire => m_Wrapper.m_Player_Player1Fire;
        public InputAction @Player2Move => m_Wrapper.m_Player_Player2Move;
        public InputAction @Player2Rotate => m_Wrapper.m_Player_Player2Rotate;
        public InputAction @Player2Fire => m_Wrapper.m_Player_Player2Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Player1Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Move;
                @Player1Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Move;
                @Player1Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Move;
                @Player1Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Rotate;
                @Player1Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Rotate;
                @Player1Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Rotate;
                @Player1Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Fire;
                @Player1Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Fire;
                @Player1Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer1Fire;
                @Player2Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Move;
                @Player2Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Move;
                @Player2Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Move;
                @Player2Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Rotate;
                @Player2Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Rotate;
                @Player2Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Rotate;
                @Player2Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Fire;
                @Player2Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Fire;
                @Player2Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayer2Fire;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Player1Move.started += instance.OnPlayer1Move;
                @Player1Move.performed += instance.OnPlayer1Move;
                @Player1Move.canceled += instance.OnPlayer1Move;
                @Player1Rotate.started += instance.OnPlayer1Rotate;
                @Player1Rotate.performed += instance.OnPlayer1Rotate;
                @Player1Rotate.canceled += instance.OnPlayer1Rotate;
                @Player1Fire.started += instance.OnPlayer1Fire;
                @Player1Fire.performed += instance.OnPlayer1Fire;
                @Player1Fire.canceled += instance.OnPlayer1Fire;
                @Player2Move.started += instance.OnPlayer2Move;
                @Player2Move.performed += instance.OnPlayer2Move;
                @Player2Move.canceled += instance.OnPlayer2Move;
                @Player2Rotate.started += instance.OnPlayer2Rotate;
                @Player2Rotate.performed += instance.OnPlayer2Rotate;
                @Player2Rotate.canceled += instance.OnPlayer2Rotate;
                @Player2Fire.started += instance.OnPlayer2Fire;
                @Player2Fire.performed += instance.OnPlayer2Fire;
                @Player2Fire.canceled += instance.OnPlayer2Fire;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnPlayer1Move(InputAction.CallbackContext context);
        void OnPlayer1Rotate(InputAction.CallbackContext context);
        void OnPlayer1Fire(InputAction.CallbackContext context);
        void OnPlayer2Move(InputAction.CallbackContext context);
        void OnPlayer2Rotate(InputAction.CallbackContext context);
        void OnPlayer2Fire(InputAction.CallbackContext context);
    }
}
