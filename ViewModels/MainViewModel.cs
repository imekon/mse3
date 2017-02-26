using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using mse.Helpers;
using mse.Models;
using Microsoft.Win32;

namespace mse.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Scene _scene;

        private ObservableCollection<ShapeViewModel> _shapes;

        private readonly DelegateCommand _newCommand;
        private readonly DelegateCommand _openCommand;
        private readonly DelegateCommand _saveCommand;
        private readonly DelegateCommand _saveAsCommand;
        private readonly DelegateCommand _exitCommand;

        private readonly DelegateCommand _cutCommand;
        private readonly DelegateCommand _copyCommand;
        private readonly DelegateCommand _pasteCommand;

        private readonly DelegateCommand _createCameraCommand;
        private readonly DelegateCommand _createPointLightCommand;
        private readonly DelegateCommand _createCubeCommand;

        public MainViewModel(Scene scene)
        {
            _scene = scene;
            _shapes = new ObservableCollection<ShapeViewModel>();

            _newCommand = new DelegateCommand(OnFileNew);
            _openCommand = new DelegateCommand(OnFileOpen);
            _saveCommand = new DelegateCommand(OnFileSave);
            _saveAsCommand = new DelegateCommand(OnFileSaveAs);
            _exitCommand = new DelegateCommand(OnExit);

            _cutCommand = new DelegateCommand(OnCut);
            _copyCommand = new DelegateCommand(OnCopy);
            _pasteCommand = new DelegateCommand(OnPaste);

            _createCameraCommand = new DelegateCommand(OnCreateCamera);
            _createPointLightCommand = new DelegateCommand(OnCreatePointLight);
            _createCubeCommand = new DelegateCommand(OnCreateCube);
        }

        private void OnFileNew(object obj)
        {
        }

        private void OnFileOpen(object obj)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Open Model Scene Editor project",
                Filter = "Model Scene Editor projects (*.mse)|*.mse",
                DefaultExt = ".mse"
            };

            var result = dialog.ShowDialog();
            if (result == true)
            {
                _scene.Load(dialog.FileName);
            }
        }

        private void OnFileSave(object obj)
        {
        }

        private void OnFileSaveAs(object obj)
        {
            var dialog = new SaveFileDialog
            {
                Title = "Save Model Scene Editor project",
                Filter = "Model Scene Editor projects (*.mse)|*.mse",
                DefaultExt = ".mse"
            };

            var result = dialog.ShowDialog();
            if (result == true)
            {
                _scene.Save(dialog.FileName);
            }
        }

        private void OnExit(object obj)
        {
            Application.Current.Shutdown(0);
        }

        private void OnCut(object obj)
        {
        }

        private void OnCopy(object obj)
        {
        }

        private void OnPaste(object obj)
        {
        }

        private void OnCreateCamera(object obj)
        {
            _scene.CreateShape("camera");
            Build();
        }

        private void OnCreatePointLight(object obj)
        {
            _scene.CreateShape("pointlight");
            Build();
        }

        private void OnCreateCube(object obj)
        {
            _scene.CreateShape("cube");
            Build();
        }

        private void Build()
        {
            var obsShapes = new ObservableCollection<ShapeViewModel>();

            foreach (var shape in _scene.Shapes)
            {
                var shapeViewModel = new ShapeViewModel(shape);
                obsShapes.Add(shapeViewModel);
            }

            _shapes = obsShapes;
        }

        public ObservableCollection<ShapeViewModel> Shapes => _shapes;

        public ICommand NewCommand => _newCommand;
        public ICommand OpenCommand => _openCommand;
        public ICommand SaveCommand => _saveCommand;
        public ICommand SaveAsCommand => _saveAsCommand;
        public ICommand ExitCommand => _exitCommand;

        public ICommand CutCommand => _cutCommand;
        public ICommand CopyCommand => _copyCommand;
        public ICommand PasteCommand => _pasteCommand;

        public ICommand CreateCameraCommand => _createCameraCommand;
        public ICommand CreatePointLightCommand => _createPointLightCommand;
        public ICommand CreateCubeCommand => _createCubeCommand;
    }
}