using Fluid_Volume_Calculation.Command;
using Fluid_Volume_Calculation.Converter;
using Fluid_Volume_Calculation.Validation;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace Fluid_Volume_Calculation.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Properties

        private string _filePath;
        public string FilePath
        {
            get => _filePath;
            set { _filePath = value; NotifyPropertyChanged(nameof(FilePath)); }
        }

        private string _gridCellSize;
        public string GridCellSize
        {
            get { return _gridCellSize; }
            set { _gridCellSize = value; NotifyPropertyChanged(nameof(GridCellSize)); }
        }

        private string _fluidContactDepth;
        public string FluidContactDepth
        {
            get { return _fluidContactDepth; }
            set { _fluidContactDepth = value; NotifyPropertyChanged(nameof(FluidContactDepth)); }
        }

        private string _horizonDepth;
        public string HorizonDepth
        {
            get { return _horizonDepth; }
            set { _horizonDepth = value; NotifyPropertyChanged(nameof(HorizonDepth)); }
        }

        private string _cubicFeet;
        public string CubicFeet
        {
            get { return _cubicFeet; }
            set { _cubicFeet = value; NotifyPropertyChanged(nameof(CubicFeet)); }
        }

        private string _cubicMeter;
        public string CubicMeter
        {
            get { return _cubicMeter; }
            set { _cubicMeter = value; NotifyPropertyChanged(nameof(CubicMeter)); }
        }

        private string _barrel;
        public string Barrel
        {
            get { return _barrel; }
            set { _barrel = value; NotifyPropertyChanged(nameof(Barrel)); }
        }

        #endregion

        #region CTOR

        public MainWindowViewModel()
        {
            BrowseButtonCommand = new RelayCommand(BrowseButtonCommandExecuted);
            EstimateVolumeCommand = new RelayCommand(EstimateVolumeCommandExecuted);
        }

        #endregion

        #region Command

        private ICommand _browseButtonCommand;
        public ICommand BrowseButtonCommand
        {
            get => _browseButtonCommand;
            set { _browseButtonCommand = value; }
        }

        private ICommand _estimateVolumeCommand;
        public ICommand EstimateVolumeCommand
        {
            get => _estimateVolumeCommand; 
            set { _estimateVolumeCommand = value; }
        }

        #endregion

        #region Methods

        private void BrowseButtonCommandExecuted(object obj)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;
            dlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dlg.DefaultExt = ".txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result.HasValue && result.Value)
            {
                // Open document 
                string filename = dlg.FileName;
                FilePath = filename;
            }
        }

        private void EstimateVolumeCommandExecuted(object obj)
        {
            string filePath = Validator.ValidateFilePath(FilePath);
            decimal gridCellSize = Validator.ValidateDecimal(GridCellSize);
            decimal fluidContact = MeterToFeetConverter.MetreToFeet(Validator.ValidateDecimal(FluidContactDepth));
            decimal horizonDepth = MeterToFeetConverter.MetreToFeet(Validator.ValidateDecimal(HorizonDepth));

            DataProcessor dataProcessor = new DataProcessor();
            Dictionary<int, string> volumes = dataProcessor.FindVolume(filePath, horizonDepth, gridCellSize, fluidContact);

            CubicFeet = volumes[0];
            CubicMeter = volumes[1];
            Barrel = volumes[2];
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
