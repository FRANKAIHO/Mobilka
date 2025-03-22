using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMTransferDataAndreev.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMTransferDataAndreev.ViewModels;

[QueryProperty(nameof(InputLesson), nameof(InputLesson))]

public partial class FirstViewModel: ObservableObject
{

    [ObservableProperty]
    private Lesson _inputLesson;

}
