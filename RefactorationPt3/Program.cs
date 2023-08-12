// See https://aka.ms/new-console-template for more information

using RefactorationPt3.Aula1;
using RefactorationPt3.Aula1.R40.RenameMethod.mysolution;
using RefactorationPt3.Aula1.R41.AddParameter.solucao;
using RefactorationPt3.Aula1.R42.RemoveParameter.solucao;
using RefactorationPt3.Aula1.R43.SeparateQueryFromModifier.solucao;
using RefactorationPt3.Aula2.R44.ParameterizeMethod.solution;
using RefactorationPt3.Aula2.R45.ReplaceParameterWithExplicitMethods.solution;
using RefactorationPt3.Aula2.R46.PreserveWholeObject.solution;
using RefactorationPt3.Aula3.R50.HideMethod.solution;
using RefactorationPt3.Aula3.R51.ReplaceConstructorWithFactoryMethod.solution;
using RefactorationPt3.Aula3.R52.ReplaceErrorCodeWithException.solution;
using RefactorationPt3.Aula3.R53.ReplaceExceptionwithTest.solution;
using RefactorationPt3.Aula6.R61.CollapseHierarchy.solution;
using RefactorationPt3.Aula6.R62.FormTemplateMethod.solution;

var listRefactoration = new List<IRefactoration>() {
    // new RenamingMethodCredito(),
    // new PricesCalculatorIncludingParameter(),
    // new CalculadoraDePrecoRemovingParameter(),
    // new ClienteSeparateQueryFromModifier(),
    // new ParameterizeMethod(),
    // new ReplaceParameterWithExplicitMethods(),
    // new PreserveWholeObject(),
    // new HideMethod(),
    // new ReplaceConstructorWithFactoryMethod(), 
    // new ReplaceErrorCodeWithException(),
    // new ReplaceExceptionWithTest(),
    // new CollapseHierarchy(),
    new FormTemplateMethod()
    
};

foreach (var refactoration in listRefactoration) {
    Console.WriteLine(refactoration);
    refactoration.Execute();    
}
