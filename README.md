# Coily
Spring Library for Unity

This is a simple implementation of damped springs for Unity.  It includes a C# port of Ryan Juckett's springs implementation (found here: https://www.ryanjuckett.com/damped-springs/), and a basic setup for running that in a MonoBehaviour.

This is also inspired by this video from Toyful Games https://www.youtube.com/watch?v=bFOAipGJGA0

# SpringRunner Setup

For each individual spring you'll need a SpringRunner.  SpringRunner has the spring setup values and will update any subscribers to its OnSpringValueChanged with the new spring position every frame.

# Spring Reactors

This library provides a way to interact with the spring sim in SpringRunner through Spring Reactors, which are MonoBehaviours that perform some action based on the current spring state.

The following reactors are provided as an example:

- Scale Reactor
- Position Reactor
- Rotaiton Reactor
- Color Reactor
