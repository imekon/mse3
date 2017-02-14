using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using mse.Helpers;
using mse.Models;

namespace mse.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Scene scene;

        private ObservableCollection<ShapeViewModel> shapes;

        private readonly DelegateCommand newCommand;
        private readonly DelegateCommand openCommand;
        private readonly DelegateCommand saveCommand;
        private readonly DelegateCommand saveAsCommand;
        private readonly DelegateCommand exitCommand;

        private readonly DelegateCommand cutCommand;
        private readonly DelegateCommand copyCommand;
        private readonly DelegateCommand pasteCommand;

        private readonly DelegateCommand createCameraCommand;
        private readonly DelegateCommand createPointLightCommand;
        private readonly DelegateCommand createCubeCommand;

        public MainViewModel(Scene scene)
        {
            this.scene = scene;
            shapes = new ObservableCollection<ShapeViewModel>();

            newCommand = new DelegateCommand(OnFileNew);
            openCommand = new DelegateCommand(OnFileOpen);
            saveCommand = new DelegateCommand(OnFileSave);
            saveAsCommand = new DelegateCommand(OnFileSaveAs);
            exitCommand = new DelegateCommand(OnExit);

            cutCommand = new DelegateCommand(OnCut);
            copyCommand = new DelegateCommand(OnCopy);
            pasteCommand = new DelegateCommand(OnPaste);

            createCameraCommand = new DelegateCommand(OnCreateCamera);
            createPointLightCommand = new DelegateCommand(OnCreatePointLight);
            createCubeCommand = new DelegateCommand(OnCreateCube);
        }

        private void OnFileNew(object obj)
        {
        }

        private void OnFileOpen(object obj)
        {
        }

        private void OnFileSave(object obj)
        {
        }

        private void OnFileSaveAs(object obj)
        {
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
            scene.CreateShape("camera");
            Build();
        }

        private void OnCreatePointLight(object obj)
        {
            scene.CreateShape("pointlight");
            Build();
        }

        private void OnCreateCube(object obj)
        {
            scene.CreateShape("cube");
            Build();
        }

        private void Build()
        {
            var obsShapes = new ObservableCollection<ShapeViewModel>();

            foreach (var shape in scene.Shapes)
            {
                var shapeViewModel = new ShapeViewModel(shape);
                obsShapes.Add(shapeViewModel);
            }

            shapes = obsShapes;
        }

        public ObservableCollection<ShapeViewModel> Shapes => shapes;

        public ICommand NewCommand => newCommand;
        public ICommand OpenCommand => openCommand;
        public ICommand SaveCommand => saveCommand;
        public ICommand SaveAsCommand => saveAsCommand;
        public ICommand ExitCommand => exitCommand;

        public ICommand CutCommand => cutCommand;
        public ICommand CopyCommand => copyCommand;
        public ICommand PasteCommand => pasteCommand;

        public ICommand CreateCameraCommand => createCameraCommand;
        public ICommand CreatePointLightCommand => createPointLightCommand;
        public ICommand CreateCubeCommand => createCubeCommand;

    }
}