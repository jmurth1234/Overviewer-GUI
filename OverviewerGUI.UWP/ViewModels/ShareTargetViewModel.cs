﻿using System;
using System.Threading.Tasks;
using System.Windows.Input;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.ShareTarget;

namespace OverviewerGUI.UWP.ViewModels
{
    public class ShareTargetViewModel : ViewModelBase
    {
        private ShareOperation _shareOperation;

        private SharedDataViewModelBase _sharedData;

        public SharedDataViewModelBase SharedData
        {
            get => _sharedData;
            set => Set(ref _sharedData, value);
        }

        private ICommand _completeCommand;

        public ICommand CompleteCommand => _completeCommand ?? (_completeCommand = new RelayCommand(OnComplete));

        public ShareTargetViewModel()
        {
        }

        public async Task LoadAsync(ShareOperation shareOperation)
        {
            // TODO WTS: Configure the Share Target Declaration for the formats you require.
            // Share Target declarations are defined in Package.appxmanifest.
            // Current declarations allow to share WebLink and image files with the app.
            // ShareTarget can be tested sharing the WebLink from Microsoft Edge or sharing images from Windows Photos.

            // TODO WTS: Customize SharedDataModelBase or derived classes adding properties for data that you need to extract from _shareOperation
            _shareOperation = shareOperation;
            if (shareOperation.Data.Contains(StandardDataFormats.StorageItems))
            {
                SharedData = new SharedDataStorageItemsViewModel();
            }

            if (shareOperation.Data.Contains(StandardDataFormats.WebLink))
            {
                SharedData = new SharedDataWebLinkViewModel();
            }

            await SharedData?.LoadDataAsync(_shareOperation);
        }

        private void OnComplete()
        {
            // TODO WTS: Implement any other logic or add a QuickLink before completing the share operation.
            // More details at https://docs.microsoft.com/en-us/windows/uwp/app-to-app/receive-data
            _shareOperation.ReportCompleted();
        }
    }
}
