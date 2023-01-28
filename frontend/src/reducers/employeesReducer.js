import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import { fetchEmployees } from "../api";

export const getEmployees = createAsyncThunk(
  "employees",
  async (id, thunkAPI) => {
    try {
      const response = await fetchEmployees(id);
      return response.data;
    } catch (error) {
      return error.response.status === 404
        ? thunkAPI.rejectWithValue("Invalid API Request")
        : thunkAPI.rejectWithValue(error);
    }
  }
);

const initialState = {
  loading: false,
  errorMessage: "",
  data: [],
};

export const employeesSlice = createSlice({
  name: "employees",
  initialState,

  extraReducers(builder) {
    builder
      .addCase(getEmployees.pending, (state, action) => {
        state.errorMessage = "";
        state.loading = true;
      })
      .addCase(getEmployees.rejected, (state, action) => {
        state.loading = false;
        state.errorMessage = action.payload;
      })
      .addCase(getEmployees.fulfilled, (state, { payload }, action) => {
        state.loading = false;
        state.data = payload;
      });
  },
});

export default employeesSlice.reducer;
