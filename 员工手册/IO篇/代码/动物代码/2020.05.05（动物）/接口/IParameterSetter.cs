// #region  Copyright (c) 2020 Ampligence LLC. All rights reserved.
//  Copyright (c) 2020 Ampligence LLC. All rights reserved.
//  /*
//                   ,-⌂Mδ╚╚╚╚δφ≈,
//                »φ╜             `╙φ,
//              »╩                  _ ╚╦
//            ,╬           ▓▌     ▓  Γ  ╠⌐
//           ╒╩          ,▓▀▓▓  ▀▀▓▀▀    ╠⌐
//           ╠          ,▓▀  ▓▓   █       ░
//          !Γ         ╒▓▀    ▀▓
//          )╡        ╓▓▀   ╚╚╚╬▓Σ╚╚╚╚╚╚╚╚╠⌐
//           ╬       ╓▓▀        ▀▓        ╬
//           ╚ε     ▄▓           ▀▓      «╩
//            ╚╦                        «╩
//             `▒                     ,╬
//               `╚-                «╝`
//                  `╙δ╦-,,,.,,-⌂Θ╜`
//  */
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
//
// Filename: IInitializable.cs
// Author:
//       John Li <johnli@ampligence.com>
// #endregion
using System;
namespace _2020._05._05_动物_.接口
{
	public interface IParameterSetter<T>
	{
		void SetParameter(T parameter);
	}
}
