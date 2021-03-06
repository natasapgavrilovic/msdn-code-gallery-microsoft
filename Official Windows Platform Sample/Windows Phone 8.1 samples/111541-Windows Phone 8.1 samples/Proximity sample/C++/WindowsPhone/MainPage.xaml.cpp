﻿// Copyright (c) Microsoft. All rights reserved.

#include "pch.h"
#include "MainPage.xaml.h"

using namespace SDKSample;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::Phone::UI::Input;


MainPage^ MainPage::Current = nullptr;

MainPage::MainPage()
{
    InitializeComponent();

    // This is a static public property that allows downstream pages to get a handle to the MainPage instance
    // in order to call methods that are in this class.
    MainPage::Current = this;

    m_IsLaunchedByTap = false;
    m_Role = Windows::Networking::Proximity::PeerRole::Peer;

    HardwareButtons::BackPressed += ref new EventHandler<BackPressedEventArgs ^>(this, &MainPage::HardwareButtons_BackPressed);		
}

void MainPage::OnNavigatedTo(NavigationEventArgs^ e)
{
    // TODO: Need to update this for phone
    // Check if this app was launched by a tap action
    String^ launchArgs = safe_cast<String^>(e->Parameter);

    if (launchArgs != nullptr)
    {
        if (launchArgs == "Windows.Networking.Proximity.PeerFinder:StreamSocket")
        {
            m_IsLaunchedByTap = true;
            m_Role = Windows::Networking::Proximity::PeerRole::Peer;
            if (!ScenarioFrame->Navigate(TypeName{ "SDKSample.PeerFinderScenario", TypeKind::Custom }))
            {
                throw ref new FailureException("Failed to navigate to PeerFinder Scenario!");
            }
        }
    }

    SuspensionManager::RegisterFrame(ScenarioFrame, "scenarioFrame");
    if (ScenarioFrame->Content == nullptr)
    {
        // When the navigation stack isn't restored navigate to the ScenarioList
        if (!ScenarioFrame->Navigate(TypeName{ "SDKSample.ScenarioList", TypeKind::Custom }))
        {
            throw ref new FailureException("Failed to create scenario list");
        }
    }
}

void MainPage::HardwareButtons_BackPressed(Object^ sender, Windows::Phone::UI::Input::BackPressedEventArgs^ e)
{	
    if (ScenarioFrame->CanGoBack)
    {
        // Clear the status block when navigating
        NotifyUser("", NotifyType::StatusMessage);

        ScenarioFrame->GoBack();

        //Indicate the back button press is handled so the app does not exit
        e->Handled = true;
    }
}

void MainPage::NotifyUser(String^ strMessage, NotifyType type)
{
    switch (type)
    {
    case NotifyType::StatusMessage:
        StatusBorder->Background = ref new SolidColorBrush(Windows::UI::Colors::Green);		
        break;
    case NotifyType::ErrorMessage:
        StatusBorder->Background = ref new SolidColorBrush(Windows::UI::Colors::Red);
        break;
    default:
        break;
    }
    StatusBlock->Text = strMessage;

    // Collapsed the StatusBlock if it has no text to conserve real estate.
    if (StatusBlock->Text != "")
    {
        StatusBorder->Visibility = Windows::UI::Xaml::Visibility::Visible;
    }
    else
    {
        StatusBorder->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    }
}

// This is used by the peerfinder scenario
bool MainPage::IsLaunchedByTap()
{
    bool isLaunchedByTap = m_IsLaunchedByTap;
    m_IsLaunchedByTap = false;
    return isLaunchedByTap;
}

// This is used by the peerfinder scenario
Windows::Networking::Proximity::PeerRole MainPage::GetLaunchRole()
{
    return m_Role;
}
