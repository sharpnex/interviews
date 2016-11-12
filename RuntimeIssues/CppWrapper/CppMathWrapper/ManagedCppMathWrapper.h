// ManagedCppMathWrapper.h

#pragma once

#include "../CppMath/MathHelper.h"

using namespace System;

namespace CppMathWrapper {

	public ref class ManagedCppMathWrapper
	{
	public:
		ManagedCppMathWrapper();

	public:
		double Vwap(System::Collections::Generic::List<System::Tuple<double, unsigned int>^>^ values);

	private:
		MathHelper *_pMathHelper;
	};
}
