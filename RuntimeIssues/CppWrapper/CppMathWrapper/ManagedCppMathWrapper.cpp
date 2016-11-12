// This is the main DLL file.

#include "stdafx.h"
#include "../CppMath/MathHelper.cpp"

#include "ManagedCppMathWrapper.h"

namespace CppMathWrapper {

	ManagedCppMathWrapper::ManagedCppMathWrapper()
	{
		_pMathHelper = new MathHelper();
	}

	double ManagedCppMathWrapper::Vwap(System::Collections::Generic::List<System::Tuple<double, unsigned int>^>^ values)
	{
		std::vector<std::pair<double, unsigned int>> input;

		for(int i = 0; i < values->Count; ++i)
		{
			Tuple<double, unsigned int>^ p = values[i];
			input.push_back(std::pair<double, unsigned int>(p->Item1, p->Item2));
		}

		return _pMathHelper->Vwap(input);
	}
}
